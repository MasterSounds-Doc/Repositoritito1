using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodaEsaWea
{
    class Validaciones
    {
        public static void soloNumeros(KeyPressEventArgs x, TextBox z)
        {
            if (Char.IsDigit(x.KeyChar))
            {
                x.Handled = false;
            }
            else if (Char.IsControl(x.KeyChar))
            {
                x.Handled = false;
            }
            else if (x.KeyChar.ToString().Equals(".") && !z.Text.Contains("."))
            {
                x.Handled = false;
            }
            else if (x.KeyChar.ToString().Equals("-") && z.Text == "" && !z.Text.Contains("-"))
            {
                x.Handled = false;
            }
            else
            {
                x.Handled = true;
                MessageBox.Show("Solo números y 1 punto decimal en la caja" + z.Name);
            }
        }
    }
}
