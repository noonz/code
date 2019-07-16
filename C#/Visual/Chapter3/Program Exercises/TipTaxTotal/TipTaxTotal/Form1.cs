using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipTaxTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double cost, tip, tax, total;

            cost = double.Parse(foodTotalBox.Text);
            tip = cost * .07;
            tax = cost * .15;
            total = cost + tip + tax;

            tipBox.Text = tip.ToString("c");
            taxBox.Text = tax.ToString("C");
            totalBox.Text = total.ToString("C");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            tipBox.Text = "";
            taxBox.Text = "";
            totalBox.Text = "";
            foodTotalBox.Text = "";
            foodTotalBox.Focus();
        }
    }
}
