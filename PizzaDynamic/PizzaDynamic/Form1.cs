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

namespace PizzaDynamic
{
    public partial class Form1 : Form
    {
        // this variable will use to set the control's visiblity.
        private bool visible;
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "pizzas.txt";
            // set the central panel Autocsroll to true
            pnlCenter.AutoScroll = true;
            //set visible properties of the controls on the form 
            //calling the modifiedvisibility()
            visible = false;
            ModifyVisibility(visible);

        }
        //we create lists for the application 
        private List<Pizza> pizzas = new List<Pizza>();
        private List<CheckBox> pizzaCheckBoxes = new List<CheckBox>();
        private List<RadioButton> rdbSmallPrices = new List<RadioButton>();
        private List<RadioButton> rdbLargePrices = new List<RadioButton>();
        private List<TextBox> txtpieces = new List<TextBox>();
        private List<Panel> panels = new List<Panel>();

        //to arrange control we have to determine the distances between the controls 
        // the distance of the first checkbox from the left side and from the top of the central panel
        private int left = 20, up = 10;
        //Two-two checkbox top left corner distance from each other vertically
        private int distY = 40;
        // the height of the controls in pixels 
        private int sizeY = 20;
        // the width of the panels contains radioButton controls
        private int panelX = 200;
        //the checkbox width with the text in pixels 
        private int sizeChk = 120;
        //radiobuttons with text in pixels
        private int sizePrice = 50;
        // the Ft (Hungarian money measuring) txt in pixels
        private int sizeFt = 40;
        //the width of the input text boxes to type the number
        // of pizzas to buy
        private int sizeTxtPiece = 50;
        //distance of Ft and pieces labelsfrom the previous left control
        private int dist = 3;

        private void ModifyVisibility(bool visible)
        {
            lblPayable.Visible = visible;
            txtPayable.Visible = visible;
            btnCalculate.Visible = visible;
            btnClear.Visible = visible;
            btnClose.Visible = visible;
            btnLoadData.Visible = visible;
        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                ReadData(fileName);
                //modify the visibility properties
                visible = true;
                ModifyVisibility(visible);
                btnLoadData.Visible = false;
                // we cancel the backgroungimage
                this.BackgroundImage = null;
            }
        }

        private void ReadData(string fileName)
        {
            //crate a communication channel to the file 
            StreamReader readPipe = new StreamReader(fileName);
            string data;
            while (!readPipe.EndOfStream)
            {
                data = readPipe.ReadLine();
                WorkingData(data);
            }
            readPipe.Close();
            //now we arrange controls of the form with calling 
            //the next method
            ArrangeControls(); 
        }
        private void WorkingData(string data)
        {
            string name;
            int price1, price2;
            string[] dataRow = data.Split(';');
            name = dataRow[0];
            price1 = int.Parse(dataRow[1]);
            price2 = int.Parse(dataRow[2]);
            Pizza pizza = new PizzaDynamic.Pizza(name, price1, price2);
            pizzas.Add(pizza);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This method places the controls to the central panel
        private void ArrangeControls()
        {
            CheckBox checkbox;
            Label label;
            RadioButton radiobutton;
            Panel panel;
            TextBox textbox;

            Label labelSmall = new Label();
            labelSmall.Text = "32 Cm";
            labelSmall.ForeColor = Color.Maroon;
            labelSmall.Location = new Point(left + sizeChk + sizePrice + dist, 15);
            this.Controls.Add(labelSmall);

            Label labelLarge = new Label();
            labelLarge.Text = "45 Cm";
            labelLarge.ForeColor = Color.Maroon;
            labelLarge.Location = new Point(left + sizeChk + 2 * sizePrice + 2 * dist + sizeFt, 15);
            this.Controls.Add(labelLarge);


            for (int i = 0; i < pizzas.Count; i++)
            {
                //Create check box object and set its properties
                checkbox = new CheckBox();
                checkbox.Text = pizzas[i].Name;
                checkbox.TextAlign = ContentAlignment.MiddleLeft;
                checkbox.Location = new Point(left, up + i * distY);
                checkbox.Size = new Size(sizeChk, sizeY);

                //Add the checkbox to the list of checkboxes
                pizzaCheckBoxes.Add(checkbox);
                //Add the checkbox to the centre panel controls collectioon
                pnlCenter.Controls.Add(checkbox);

                //Panel for the radiobutton pairs and set properties
                panel = new Panel();
                panel.Size = new Size(panelX, sizeY);
                panel.Location = new Point(left + sizeChk, up + i * distY);
                // add the panel to the center panel controls collection 
                pnlCenter.Controls.Add(panel);

                // radiobutton object for smallsize
                radiobutton = new RadioButton();
                radiobutton.Size = new Size(sizePrice, sizeY);
                radiobutton.TextAlign = ContentAlignment.MiddleRight;
                radiobutton.Text = pizzas[i].SmallSizePrice.ToString();
                radiobutton.Location = new Point(0, 0);

                rdbSmallPrices.Add(radiobutton);
                panel.Controls.Add(radiobutton);

                //label objects for the money (Ft)
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = "Ft";
                label.Location = new Point(sizePrice + dist, 0);
                label.Size = new Size(sizeFt, sizeY);
                panel.Controls.Add(label);

                //radibutton largepiece
                radiobutton = new RadioButton();
                radiobutton.Size = new Size(sizePrice,sizeY);
                //the position of the text
                radiobutton.TextAlign = ContentAlignment.MiddleRight;
                radiobutton.Text = pizzas[i].LargeSizePrice.ToString();
                radiobutton.Location = new Point(sizePrice + dist + sizeFt, 0);
                // not mandatory
                radiobutton.Checked = true;

                rdbLargePrices.Add(radiobutton);
                panel.Controls.Add(radiobutton);

                //ft text (label) this is just to represent the currency
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = "Ft";
                label.Location = new Point(2 * sizePrice + 2 * dist + sizeFt, 0);
                label.Size = new Size(sizeFt, sizeY);
                panel.Controls.Add(label);

                //textbox to type number of pieces
                textbox = new TextBox();
                textbox.TextAlign = HorizontalAlignment.Right;
                textbox.Location = new Point(left + sizeChk + panelX, up + i * distY);
                textbox.Size = new Size(sizeTxtPiece, sizeY);
                txtpieces.Add(textbox);
                pnlCenter.Controls.Add(textbox);

                //piece text to measure unit 
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleRight;
                label.Text = "Pcs";
                label.Location = new Point(left+sizeChk+panelX+sizeTxtPiece+dist,up+i*distY);
                label.Size = new Size(sizeFt, sizeY);
                pnlCenter.Controls.Add(label);
            }
        }

    }
}
