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
    public partial class ResultForm : Form {
        public ResultForm()
        {
            InitializeComponent();
        }
        public List<PineTree> PineTrees { get; set; }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            foreach (PineTree tree in PineTrees)
            {
                rchResult.Text += tree + tree.VoteNumber.ToString().PadLeft(4) + " votes" + Environment.NewLine;
            }
        }
    }
}
