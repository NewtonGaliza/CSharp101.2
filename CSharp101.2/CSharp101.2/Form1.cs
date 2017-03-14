using System;
using System.Windows.Forms;

namespace CSharp101._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Check the CheckBox", "Checked?");
            }
            else if (checkBox1.Checked)
            {
                MessageBox.Show("CheckBox is checked", "Checked?");
            }
        }
    }
}
