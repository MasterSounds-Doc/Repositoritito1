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
    public partial class Form5 : Form
    {
        double primero;
        double segundo;
        double resultado;

        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double p;
            Double.TryParse(textBox1.Text, out p);
            primero = p;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double p;
            Double.TryParse(textBox2.Text, out p);
            segundo = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "No hay número 1";
            }
            else if (textBox2.Text == "")
            {
                label1.Text = "No hay número 2";
            }
            else if (textBox1.Text == "-." || textBox2.Text == "-.")
            {
                label1.Text = "No se puede hacer eso";
            }
            else
            {

                resultado = primero + segundo;
                label1.Text = Convert.ToString(resultado);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "No hay número 1";
            }
            else if (textBox2.Text == "")
            {
                label1.Text = "No hay número 2";
            }
            else if (textBox1.Text == "-." || textBox2.Text == "-.")
            {
                label1.Text = "No se puede hacer eso";
            }
            else
            {

                resultado = primero - segundo;
                label1.Text = Convert.ToString(resultado);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "No hay número 1";
            }
            else if (textBox2.Text == "")
            {
                label1.Text = "No hay número 2";
            }
            else if (textBox1.Text == "-." || textBox2.Text == "-.")
            {
                label1.Text = "No se puede hacer eso";
            }
            else
            {

                resultado = primero * segundo;
                label1.Text = Convert.ToString(resultado);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "No hay número 1";
            }
            else if (textBox2.Text == "")
            {
                label1.Text = "No hay número 2";
            }
            else if (textBox1.Text == "-." || textBox2.Text == "-.")
            {
                label1.Text = "No se puede hacer eso";
            }
            else
            {
                if (textBox2.Text == "0")
                {
                    label1.Text = "No se puede dividir entre 0";
                }
                else
                {
                    resultado = primero / segundo;
                    label1.Text = Convert.ToString(resultado);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e, textBox1);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e, textBox2);
        }
    }
}
