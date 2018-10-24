using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChristmasTrees {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";

        }
        private int minimumHeight;
        private List<PineTree> pinetrees = new List<PineTree>();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    string filename = openFileDialog1.FileName;
                    InputData(filename);
                    openToolStripMenuItem.Enabled = false;
                    sizeToolStripMenuItem.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("There is an error with file reading", "ERROR");
                }
            }
        }

        private void InputData(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string[] data;
            string name, picname;
            int height;
            while (!reader.EndOfStream)
            {
                string datarow = reader.ReadLine();
                data = datarow.Split(';');
                name = data[0];
                height = int.Parse(data[1]);
                picname = data[2];

                pinetrees.Add(new PineTree(name, height, picname));
            }
            reader.Close();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeForm sizeForm = new SizeForm();
            sizeForm.ShowDialog();
            minimumHeight = sizeForm.MinimumSize;
            voteToolStripMenuItem.Enabled = true;
        }

        private void voteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoteForm voteForm = new VoteForm();
            List<PineTree> trees = new List<PineTree>();
            foreach (PineTree tree in pinetrees)
            {
                if (tree.Height>=minimumHeight)
                {
                    trees.Add(tree);
                }
            }
            voteForm.PineTrees = trees;
            voteForm.Show();
            resultToolStripMenuItem.Enabled = true;
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm resForm = new ResultForm();
            int max = Max(pinetrees);
            List<PineTree> winners = new List<PineTree>();
            foreach (PineTree tree in pinetrees)
            {
                if (tree.VoteNumber==max)
                {
                    winners.Add(tree);
                }
            }
            resForm.PineTrees = winners;
            resForm.ShowDialog();
            saveToolStripMenuItem.Enabled = true;
        }

        private int Max(List<PineTree> pinetrees)
        {
            int max = pinetrees[0].VoteNumber;
            foreach (PineTree tree in pinetrees)
            {
                if (max<tree.VoteNumber)
                {
                    max = tree.VoteNumber;
                }
            }
            return max;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    string filename = saveFileDialog1.FileName;
                    WriteOut(filename);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error when write the file", "Error");
                }
            }
        }

        private void WriteOut(string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            foreach (PineTree tree in pinetrees)
            {
                writer.WriteLine(tree.PineTypeName + ";" + tree.Height + ";" + tree.VoteNumber);
            }
            writer.Close();
        }
    }
}
