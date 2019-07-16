using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconomy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;
            double mpg;

            miles = double.Parse(milesTextBox.Text);
            gallons = double.Parse(gallonsTextBox.Text);
            mpg = miles / gallons;

            mpgLabel.Text = mpg.ToString() + "/mpg";
            milesTextBox.Text = "";
            gallonsTextBox.Text = "";
        }
    }
}
