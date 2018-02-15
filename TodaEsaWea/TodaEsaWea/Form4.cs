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
    public partial class Form4 : Form
    {
        bool Play = false;
        string[] mp3;
        string[] rmp3;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Busqueda = new OpenFileDialog();
            Busqueda.Multiselect = true;
            if (Busqueda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mp3 = Busqueda.SafeFileNames;
                rmp3 = Busqueda.FileNames;
                foreach(var mp3 in mp3)
                {
                    listBox1.Items.Add(mp3);
                }
                reproductor.URL = rmp3[0];
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reproductor.URL = rmp3[listBox1.SelectedIndex];
        }
    }
}
