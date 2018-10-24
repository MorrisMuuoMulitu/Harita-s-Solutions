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
    public partial class SizeForm : Form {
        public SizeForm()
        {
            InitializeComponent();
        }

        // property to pass data to other forms
        public int MinimumSize { get; set; }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                this.MinimumSize = int.Parse(txtSize.Text);
                if (MinimumSize<=0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                MessageBox.Show(" the Size is too small", "Error");
            }
        }
    }
}
