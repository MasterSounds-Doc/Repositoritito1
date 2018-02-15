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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Dummkopfs!")
            {
                label1.Text = "Idiotas!";
            }
            if (comboBox1.Text == "Schnell!")
            {
                label1.Text = "Deprisa!";
            }
            if (comboBox1.Text == "Raus, Raus!")
            {
                label1.Text = "Vamos, Vamos!";
            }
            if (comboBox1.Text == "Gesundheit!")
            {
                label1.Text = "A tu salud!";
            }
            if (comboBox1.Text == "Fess...")
            {
                label1.Text = "Estoy cansado...";
            }
            if (comboBox1.Text == "Hide coward!")
            {
                label1.Text = "Huye covarde!";
            }
            if (comboBox1.Text == "I'm comming for you!")
            {
                label1.Text = "Voy por ti!";
            }
            if (comboBox1.Text == "Wich one of you is crying?")
            {
                label1.Text = "Quien de ustedes esta llorando?";
            }
            if (comboBox1.Text == "Good Times!")
            {
                label1.Text = "Buenos Tiempos!";
            }
            if (comboBox1.Text == "You cannot beat me!")
            {
                label1.Text = "No puedes vencerme!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hide coward!");
            comboBox1.Items.Add("I'm comming for you!");
            comboBox1.Items.Add("Wich one of you is crying?");
            comboBox1.Items.Add("Good Times!");
            comboBox1.Items.Add("You cannot beat me!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Dummkopfs!");
            comboBox1.Items.Add("Schnell!");
            comboBox1.Items.Add("Raus, Raus!");
            comboBox1.Items.Add("Gesundheit!");
            comboBox1.Items.Add("Fess...");
        }
    }
}
