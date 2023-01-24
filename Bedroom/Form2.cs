using System;
using System.Windows.Forms;

namespace Bedroom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }
    }
}
