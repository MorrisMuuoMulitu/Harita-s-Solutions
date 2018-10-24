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

namespace christmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }
        private int minSize;
        private List<Tree> trees = new List<Tree>();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog1.FileName;
                    InputData(fileName);
                    openToolStripMenuItem.Enabled = false;
                    sizeToolStripMenuItem.Enabled = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("there is a problem in openning the specified file", "error");
                }
            }
        }

        private void InputData(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string[] data;
            string name, picname;
            int size;
            while (!reader.EndOfStream)
            {
                string datas = reader.ReadLine();
                data = datas.Split(';');
                name = data[0];
                picname = data[2];
                size = int.Parse(data[1]);
                trees.Add(new Tree(name, size, picname));
            }
            reader.Close();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size size = new size();
            size.ShowDialog();
            minSize = size.MinimumSize;
            voteToolStripMenuItem.Enabled = true;
        }

        private void voteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vote vote = new Vote();
            List<Tree> pinetrees = new List<Tree>();
            foreach (Tree tree in trees)
            {
                if (tree.Size >= minSize)
                {
                    pinetrees.Add(tree);
                }
               
            }
            
        }
    }
}
