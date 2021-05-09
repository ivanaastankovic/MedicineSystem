using Client.Helpers;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UIControllers
{
    public class AddProizvodjacController
    {
        internal bool Save(TextBox txtNaziv, TextBox txtGodina, TextBox txtImePrezime, TextBox txtAdresa)
        {
            if(FormHelper.EmptyFieldValidation(txtNaziv) |
                FormHelper.EmptyFieldValidation(txtGodina) |
                FormHelper.EmptyFieldValidation(txtImePrezime) |
                FormHelper.EmptyFieldValidation(txtAdresa))
            {
                MessageBox.Show("Sva polja su obavezna.");

                return false;
            }
            if(!int.TryParse(txtGodina.Text,out _))
            {
                MessageBox.Show("Godina osnivanja mora biti broj.");
                return false;
            }
            ProizvodjacLekova proizvodjac = new ProizvodjacLekova()
            {
                NazivProizvodjaca = txtNaziv.Text,
                GodinaOsnivanja = int.Parse(txtGodina.Text),
                ImePrezimeVlasnika = txtImePrezime.Text,
                Adresa = txtAdresa.Text
            };
            if (!Communication.Communication.Instance.AddProizvodjac(proizvodjac))
            {
                return false;
            }
            return true;
        }
    }
}
