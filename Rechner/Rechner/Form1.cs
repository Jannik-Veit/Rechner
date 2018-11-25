using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (ergebnisTextBox.Text=="0")
                ergebnisTextBox.Clear();

            Button click = (Button)sender;
            ergebnisTextBox.Text = ergebnisTextBox.Text + click.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ergebnisTextBox.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }
    }
}
