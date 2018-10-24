using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamiControls
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AutoSize = true;
            this.Padding = new Padding(0, 0, 20, 20);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private List<TextBox> inputTextBoxes;

        private void btnGenerate_Click(object sender, EventArgs e) {
            // Get the number of input textBoxes
            int inputNumber = int.Parse(txtNumbValues.Text);

            // Initialize List of input textBoxes
            inputTextBoxes = new List<TextBox>();

            // Generate labels and textBoxes
            for (int i = 1; i <= inputNumber; i++) {
                Label inputLabel = new Label();
                TextBox inputTextBox = new TextBox();

                // Initialize label properties
                inputLabel.Text = "Input " + i;
                inputLabel.Location = new Point(30, txtNumbValues.Bottom + (i * 30));
                inputLabel.AutoSize = true;

                //Initialize text boxes properties
                inputTextBox.Location = new Point(inputLabel.Width, inputLabel.Top - 3);
                //Add the newly created text box to the list of input text boxes
                inputTextBoxes.Add(inputTextBox);
                //Add the labels and text box to the form
                this.Controls.Add(inputLabel);
                this.Controls.Add(inputTextBox);
                this.CenterToScreen();
            }
            //Create an Add button
            Button btnAdd = new Button();
            //Initialize Properties
            btnAdd.Text = "Add";
            //Make the button show up in the middle of the form 
            // and right below the last input box
            btnAdd.Location = new Point(this.Width / 2 - btnAdd.Width / 2,
            inputTextBoxes[inputTextBoxes.Count - 1].Bottom + 20);
            //Add an event handler to the button's click event
            btnAdd.Click += new EventHandler(btnAdd_Click);
            //Add the button to the form
            this.Controls.Add(btnAdd);
            //Center the form to the screen
            this.CenterToScreen();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            int sum=0;
            foreach (TextBox textBoxItem in inputTextBoxes) {
                if (textBoxItem.Text==string.Empty) {
                    MessageBox.Show("Please fill in the all textBoxes!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else {
                    sum += int.Parse(textBoxItem.Text);
                }
            }
            MessageBox.Show("The sum is : "+sum);
        }

    }
}
