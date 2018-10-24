using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace christmas
{
    public partial class Vote : Form
    {

        public Vote()
        {
            InitializeComponent();
        }
        internal List<Tree> Trees { get; set; }
        private List<RadioButton> radioButtons = new List<RadioButton>();

        private void Vote_Load(object sender, EventArgs e)
        {
            PlaceControlls();
        }

        private void PlaceControlls()
        {
            PictureBox pctrBox;
            RadioButton rdb;
            int left = 15, top = 15, distX = 40, distY = 110;
            int picX = 120, picY = 80;
            pnlCenter.AutoScroll = true;

            for (int i = 0; i < Trees.Count; i++)
            {
                pctrBox = new PictureBox();
                pctrBox.Location = new Point(left + picX + distX, top + (i * distY));
                pctrBox.Size = new Size(picX, picY);
                pctrBox.Image = Image.FromFile(Trees[i].PicName);
                pctrBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pnlCenter.Controls.Add(pctrBox);
                rdb = new RadioButton();
                rdb.Text = Trees[i].Name;
                rdb.AutoSize = true;
                rdb.Location = new Point(left, top + picY / 2 + i * distY);
                pnlCenter.Controls.Add(rdb);
                radioButtons.Add(rdb);

            }
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < radioButtons.Count; i++)
            {
                if (radioButtons[i].Checked)
                {
                    Trees[i].ModifyVoteNumber();
                    radioButtons[i].Checked = false;
                    break;

                }

            }
        }
    }
}
