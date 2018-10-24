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


namespace ImageAlbum
{
    public partial class Form1 : Form
    {
        private string folderPath;
        private List<PictureBox> pictures=new List<PictureBox>();
        private List<string> fileNames=new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            PictureBox pics;
            int i = 0;

            folderBrowser.SelectedPath = Directory.GetCurrentDirectory();
            if (folderBrowser.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            folderPath = folderBrowser.SelectedPath;
            fileNames.AddRange( Directory.GetFiles(folderPath));
            if (fileNames.Count==0)
            {
                MessageBox.Show("Unable to find any image files");
                return;
            }
            this.Text = folderPath;
            foreach (var item in fileNames)
            {
                pics = new PictureBox();
                pics.Size = new System.Drawing.Size(200, 150);
                // We use the StretchImage property to set the SizeMode
                pics.SizeMode = PictureBoxSizeMode.StretchImage;
                pics.Image = new Bitmap(item);
                // after we created the picturebox object, we add it to the flowLayout panel
                flowPanel.Controls.Add(pics);
            }
        }
    }
}
