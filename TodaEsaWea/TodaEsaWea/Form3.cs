using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodaEsaWea
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = "Hombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = "Mujer";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = "Enserio...?";
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a;
            
            a = textBox1.Text;
            label5.Text = a;

            label7.Text = numericUpDown1.Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
