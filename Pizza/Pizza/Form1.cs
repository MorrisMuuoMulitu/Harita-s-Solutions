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

namespace PizzaSimple2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Pizza> pizzas = new List<Pizza>();
        private string fileName = "pizza.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (InputData())
                {
                    ArrangeControls();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ArrangeControls()
        {
            throw new NotImplementedException();
        }

        private bool InputData()
        {
            bool success = false;
            StreamReader readerPipe = null;
            try
            {
                readerPipe = new StreamReader(fileName);
                ReadTheData(readerPipe);
                success = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Error during the file reading", "Error");
                success = false;
            }
            finally
            {
                if (readerPipe!=null)
                {
                    readerPipe.Close();
                }
            }

        }

        private void ReadTheData(StreamReader readerPipe)
        {
            string dataLine;
            while (!readerPipe.EndOfStream)
            {
                dataLine = readerPipe.ReadLine();
                WorkingData(dataLine);
            }
        }

        private void WorkingData(string dataLine)
        {
            string[] data = dataLine.Split(';');
            pizzas.Add(new Pizza(data[0], int.Parse(data[1]), int.Parse(data[2])));
        }
        private List<CheckBox> chkBokes = new List<CheckBox>;
        private int xDist = 10, yDist = 10, yMidDist = 40;
        private CheckBox chkBox;
        private void ArrangeControls()
        {
            for (int i = 0; i < pizzas.Count; i++)
            {
                chkBox = new CheckBox();
                chkBox.Location = new Point(xDist, yDist + i * yMidDist);
                chkBox.Text = pizzas[i].Name;

                plnCenter.Controls.Add(chkBox);
            }
        }


    }
}
