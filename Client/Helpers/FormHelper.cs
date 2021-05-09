using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Helpers
{
    public static class FormHelper
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightSalmon;
                return true;
            }
            else
            {
                txt.BackColor = Color.White;
                return false;
            }
        }

      
    }
}
