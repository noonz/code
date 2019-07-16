using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTranslator
{
    public partial class languageTranslator : Form
    {
        public languageTranslator()
        {
            InitializeComponent();
        }

        private void italian_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buongiorno";
        }

        private void spanish_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos Dias";
        }

        private void german_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";
        }
    }
}
