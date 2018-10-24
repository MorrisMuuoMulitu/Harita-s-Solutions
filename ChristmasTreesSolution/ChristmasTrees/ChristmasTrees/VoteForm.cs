using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasTrees {
    public partial class VoteForm : Form {
        public VoteForm()
        {
            InitializeComponent();
        }

        public List<PineTree> PineTrees { get; set; }
        private List<RadioButton> radiobuttons = new List<RadioButton>();

        private void VoteForm_Load(object sender, EventArgs e)
        {
            PlaceControlls();
        }

        private void PlaceControlls()
        {
            PictureBox pctrBox;
            RadioButton rdb;

            int left = 15, top = 15, distx = 40, dist = 110;
            int picX = 120, picY = 80;

            for (int i = 0; i < PineTrees.Count; i++)
            {
                pctrBox = new PictureBox();
                pctrBox.Location = new Point(left + picX + distx, top + i * dist);
                pctrBox.Size = new Size(picX, picY);
                pctrBox.Image = Image.FromFile(PineTrees[i].PicName);
                pctrBox.SizeMode = PictureBoxSizeMode.StretchImage;

                pnlCenter.Controls.Add(pctrBox);

                rdb = new RadioButton();
                rdb.AutoSize = true;
                rdb.Location = new Point(left, top + picY / 2 + i * dist);
                rdb.Text = PineTrees[i].ToString();

                pnlCenter.Controls.Add(rdb);
                radiobuttons.Add(rdb);
            }
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < radiobuttons.Count; i++)
            {
                if (radiobuttons[i].Checked)
                {
                    PineTrees[i].ModifyVoteNumber();
                    radiobuttons[i].Checked = false;
                    break;
                }
            }
        }
    }
}
