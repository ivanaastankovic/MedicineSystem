using Client.Forms;
using Client.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UIControllers
{
    public class LoginController
    {
        public bool Login(TextBox txtUsername, TextBox txtPassword)
        {
            if(FormHelper.EmptyFieldValidation(txtUsername) | FormHelper.EmptyFieldValidation(txtPassword))
            {
                MessageBox.Show("Sva polja su obavezna!");
                return false;
            }
            try
            {
                if (!Communication.Communication.Instance.Login(txtUsername.Text, txtPassword.Text))
                {
                    MessageBox.Show("Korisnik ne postoji ili je vec ulogovan. Pokusajte ponovo.");
                    return false;
                }
                MessageBox.Show("Uspešna prijava na sistem!");
                return true;
            }
            catch (IOException)
            {
                MessageBox.Show("Serverska greška. Pokušajte kasnije.");
                return false;
            }
            
        }

        internal void LogOut()
        {
            Communication.Communication.Instance.LogOut();
        }
    }
}
