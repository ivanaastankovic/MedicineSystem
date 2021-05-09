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
    public class ChangeOblikLekaController
    {
        internal void SetUIData(Label lblLekOblik, TextBox txtJacina, ComboBox cbJedinicaMere, TextBox txtBoja, JacinaLeka izabranaJacinaLeka, Lek izabraniLek)
        {
            lblLekOblik.Text = $"{izabraniLek.NazivLeka}: {izabranaJacinaLeka.Oblik.NazivOblika}";
            txtJacina.Text = izabranaJacinaLeka.Jacina.ToString();
            txtBoja.Text = izabranaJacinaLeka.Boja.ToString();
            cbJedinicaMere.SelectedItem = izabranaJacinaLeka.Jedinica;
        }

        internal void SetComboBox(ComboBox cbJedinicaMere)
        {
            cbJedinicaMere.DataSource = Enum.GetValues(typeof(JedinicaMere));
        }

        internal JacinaLeka SaveChanges(TextBox txtJacina, ComboBox cbJedinicaMere, TextBox txtBoja, Lek izabraniLek, JacinaLeka izabranaJacina)
        {
            if (FormHelper.EmptyFieldValidation(txtJacina) |
                FormHelper.EmptyFieldValidation(txtBoja))
            {
                MessageBox.Show("Sva polja su obavezna.");
                return null;
            }
            if (!int.TryParse(txtJacina.Text, out _))
            {
                MessageBox.Show("Jacina leka mora biti ceo broj.");
                return null;
            }
            if (cbJedinicaMere.SelectedItem == null)
            {
                MessageBox.Show("Izaberite jedinicu mere.");
                return null;
            }
            izabranaJacina.Jacina = int.Parse(txtJacina.Text);
            izabranaJacina.Jedinica = (JedinicaMere)cbJedinicaMere.SelectedItem;
            izabranaJacina.Boja = txtBoja.Text;
            izabranaJacina.UpdateValue = $"jacina={izabranaJacina.Jacina}, jedinicamere={(int)izabranaJacina.Jedinica},boja='{izabranaJacina.Boja}'";
            izabranaJacina.SelectWhere = $"where jacinalekaid={izabranaJacina.JacinaLekaId}";
            return izabranaJacina;
        }
    }
}
