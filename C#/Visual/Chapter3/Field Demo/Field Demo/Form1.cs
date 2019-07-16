using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Field_Demo
{
    public partial class Form1 : Form
    {
        private string name = "Charles";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = "Dave";
        }

        private void noonzButton_Click(object sender, EventArgs e)
        {
            name = "Noonz";
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }
    }
}
