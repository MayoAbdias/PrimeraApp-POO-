using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class ValidacionTextBox
    {
        public static bool textVacios(TextBox textB)
        {
            if(textB.Text == string.Empty)
            {
                textB.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool soloNumeros(KeyPressEventArgs num)
        {
            if (Char.IsNumber(num.KeyChar))
            {
                num.Handled = false;
                return true;
            }else if (Char.IsControl(num.KeyChar))
            {
                num.Handled = false;
                return true;
            }
            else
            {
                num.Handled = true;
                return false;
            }
        }
    }
}
