using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class latinTranslator : Form
    {
        public latinTranslator()
        {
            InitializeComponent();
        }

        private void sinister_Click(object sender, EventArgs e)
        {
            translatorBox.Text = "Left";
        }

        private void dexter_Click(object sender, EventArgs e)
        {
            translatorBox.Text = "Right";
        }

        private void medium_Click(object sender, EventArgs e)
        {
            translatorBox.Text = "Center";
        }
    }
}
