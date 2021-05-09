using Client.Helpers;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UIControllers
{
    public class AddJacinaLekaController
    {
        OblikLeka oblikLeka;
        BindingList<JacinaLeka> jacineOblika = new BindingList<JacinaLeka>();
        public AddJacinaLekaController(OblikLeka oblikLeka)
        {
            this.oblikLeka = oblikLeka;
        }

        internal void SetComboBox(ComboBox cbJedinicaMere)
        {
            cbJedinicaMere.DataSource = Enum.GetValues(typeof(JedinicaMere));
            cbJedinicaMere.SelectedIndex = -1;
        }

        internal void SaveJacina(TextBox txtJacina, TextBox txtBoja, ComboBox cbJedinicaMere, DataGridView dgvJacine)
        {
            if (FormHelper.EmptyFieldValidation(txtBoja) |
                FormHelper.EmptyFieldValidation(txtJacina))
            {
                MessageBox.Show("Sva polja su obavezna.");
                return;
            }
            if (!int.TryParse(txtJacina.Text, out _))
            {
                MessageBox.Show("Jacina leka mora biti ceo broj.");
                return;
            }
            if (cbJedinicaMere.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati jedinicu mere.");
                return;
            }
            JacinaLeka jacinaOblika = new JacinaLeka
            {
                Jacina = int.Parse(txtJacina.Text),
                Boja = txtBoja.Text,
                Jedinica = (JedinicaMere)cbJedinicaMere.SelectedItem,
                //Lek
                Oblik = oblikLeka
            };
            jacineOblika.Add(jacinaOblika);
            dgvJacine.DataSource = null;
            dgvJacine.DataSource = jacineOblika;
        }

        internal List<JacinaLeka> GetJacine()
        {
            return jacineOblika.ToList();
        }

        internal void RemoveJacina(DataGridView dgvJacine)
        {
            if (dgvJacine.SelectedRows.Count != 1)
            {
                MessageBox.Show("Izaberite jedan red koji želite da obrišete.");
                return;
            }
            JacinaLeka jacinaDGV = (JacinaLeka)dgvJacine.SelectedRows[0].DataBoundItem;
            JacinaLeka jacinaLekaDelete = jacineOblika.First(j => j.JacinaLekaId == jacinaDGV.JacinaLekaId);
            jacineOblika.Remove(jacinaLekaDelete);
            dgvJacine.DataSource = null;
            dgvJacine.DataSource = jacineOblika;
        }
    }
}

