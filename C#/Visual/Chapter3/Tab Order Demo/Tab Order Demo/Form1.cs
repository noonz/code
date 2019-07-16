using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tab_Order_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string nameClass = classBox.Text;
            string nameRace = raceBox.Text;

            outputDisplayBox.Text = "Name: "+ name + " Class: " + nameClass + " Race: " + nameRace;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            classBox.Text = "";
            raceBox.Text = "";
            outputDisplayBox.Text = "";
            nameBox.Focus();
        }
    }
}
