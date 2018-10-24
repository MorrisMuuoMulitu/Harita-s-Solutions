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
    public partial class size : Form
    {
        public size()
        {
            InitializeComponent();
        }
        //property to pass data trough oder forms
        public int MinimumSize { get; set; } 

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                MinimumSize = int.Parse(txtMinSize.Text);
                if (MinimumSize<=0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("tree is too small", "error");

            }
           
        }
    }
}
