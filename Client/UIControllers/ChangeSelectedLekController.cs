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
    public class ChangeSelectedLekController
    {
        BindingList<JacinaLeka> jacineZaPrikaz = new BindingList<JacinaLeka>(); //lista za prikaz
        public BindingList<JacinaLeka> sveJacine { get; set; } = new BindingList<JacinaLeka>(); //lista konacnih jacina

        // FrmChangeSelectedLek controller 
        internal void FillForm(TextBox txtMehanizam, TextBox txtTrajanjeTerapije, DataGridView dgvJacine, ComboBox cbOblik, Lek izabraniLek)
        {
            izabraniLek.IzbrisaneJacine = new List<JacinaLeka>();
            izabraniLek.IzmenjeneJacine = new List<JacinaLeka>();
            izabraniLek.DodateJacine = new List<JacinaLeka>();
            txtMehanizam.Text = izabraniLek.MehanizamDejstva;
            txtTrajanjeTerapije.Text = izabraniLek.TrajanjeTerapije.ToString();

            JacinaLeka jacinaLeka = new JacinaLeka
            {
                Lek = new Lek
                {
                    LekId = izabraniLek.LekId
                },
                SelectWhere = $"where l.lekid={izabraniLek.LekId}"
            };
            // postavljanje dataGridView-a
            sveJacine = new BindingList<JacinaLeka>(Communication.Communication.Instance.GetObliciLeka(jacinaLeka));
            dgvJacine.DataSource = null;
            dgvJacine.DataSource = sveJacine;

            // postavljanje comboBox-a
            List<object> cbData = new List<object> { "None" };
            List<OblikLeka> oblici = Communication.Communication.Instance.GetOblici(new OblikLeka());
            foreach (OblikLeka oblik in oblici)
            {
                cbData.Add(oblik);
            }
            cbOblik.DataSource = cbData;
            cbOblik.SelectedIndex = 0;
        }
        // metoda za update dgvJacina 
        internal void setDGVJacine(DataGridView dgvJacine, ComboBox cbOblik, Lek izabraniLek, Button btnAddOblik)
        {

            JacinaLeka jacina = new JacinaLeka()
            {
                Lek = new Lek
                {
                    LekId = izabraniLek.LekId
                }
            };
            if (cbOblik.SelectedItem.ToString() == "None")
            {
                btnAddOblik.Enabled = false;
                dgvJacine.DataSource = null;
                dgvJacine.DataSource = sveJacine;
                return;
            }
            jacineZaPrikaz.Clear();
            OblikLeka izabraniOblik = (OblikLeka)cbOblik.SelectedItem;
            btnAddOblik.Enabled = true;

            foreach (JacinaLeka j in sveJacine)
            {
                if (j.Lek.LekId == izabraniLek.LekId && j.Oblik.OblikLekaId == izabraniOblik.OblikLekaId)
                    jacineZaPrikaz.Add(j);
            }
            dgvJacine.DataSource = null;
            dgvJacine.DataSource = jacineZaPrikaz;

        }

        internal void UpdateLek(Lek lek)
        {
            if (Communication.Communication.Instance.ChangeLek(lek))
                MessageBox.Show("Informacije o leku su uspešno izmenjene.");
            else
                MessageBox.Show("Sistem ne može da zapamti lek.");
        }

        internal void ChangeJacina(JacinaLeka izmenjenaJacina, DataGridView dgvJacine, Lek izabraniLek)
        {
            if (dgvJacine.SelectedRows[0] == null)
                return;
            JacinaLeka novaJacina = (JacinaLeka)dgvJacine.SelectedRows[0].DataBoundItem;
            novaJacina = izmenjenaJacina;
            if (novaJacina != null)
            {
                JacinaLeka jacina = sveJacine.First(j => j.JacinaLekaId == novaJacina.JacinaLekaId);
                jacina = novaJacina;
                izabraniLek.IzmenjeneJacine.Add(izmenjenaJacina);       ////////////////////////////////////////////////////////
            }
        }

        internal Lek SaveChanges(Lek izabraniLek, TextBox txtMehanizam, TextBox txtTrajanjeTerapije, DataGridView dgvJacine)
        {
            if (FormHelper.EmptyFieldValidation(txtMehanizam) |
                FormHelper.EmptyFieldValidation(txtTrajanjeTerapije)
                )
            {
                MessageBox.Show("Sva polja su obavezna.");
                return null;
            }
            if (!double.TryParse(txtTrajanjeTerapije.Text, out _))
            {
                MessageBox.Show("Trajanje terapije mora biti ceo ili decimalni broj.");
                return null;
            }
            izabraniLek.MehanizamDejstva = txtMehanizam.Text;
            izabraniLek.TrajanjeTerapije = double.Parse(txtTrajanjeTerapije.Text);
            //foreach (JacinaLeka jacina in sveJacine)
            //{
            //    izabraniLek.JacineLeka.Add(jacina);
            //}
            izabraniLek.UpdateValue = $"mehanizamdejstva='{izabraniLek.MehanizamDejstva}', trajanjeterapije={izabraniLek.TrajanjeTerapije}";
            izabraniLek.SelectWhere = $"where lekid={izabraniLek.LekId}";
            return izabraniLek;
        }

        internal void FillSveJacine(List<JacinaLeka> jacine, Lek izabraniLek)
        {
            foreach (JacinaLeka jacina in jacine)
            {
                jacina.Lek = izabraniLek;
                sveJacine.Add(jacina);
                //jacina.InsertValues = $"{jacina.Lek.LekId},{jacina.Oblik.OblikLekaId},{jacina.Jacina},{(int)jacina.Jedinica},'{jacina.Boja}'";
                izabraniLek.DodateJacine.Add(jacina); /////////////////////////////////////////
            }
        }

        internal void DeleteOblik(DataGridView dgvJacine, Lek izabraniLek)
        {
            if (dgvJacine.SelectedRows.Count != 1)
            {
                MessageBox.Show("Izaberite jedan oblik koji želite da obrišete.");
                return;
            }
            JacinaLeka jacinaDelete = (JacinaLeka)dgvJacine.SelectedRows[0].DataBoundItem;
            sveJacine.Remove(jacinaDelete);

            if (izabraniLek.DodateJacine.Any(j => j.JacinaLekaId == jacinaDelete.JacinaLekaId))
            {
                izabraniLek.DodateJacine.Remove(jacinaDelete);
            }
            else
            {
                jacinaDelete.SelectWhere = $"where jacinalekaid= {jacinaDelete.JacinaLekaId} and lekid={jacinaDelete.Lek.LekId} and oblikid={jacinaDelete.Oblik.OblikLekaId}";
                izabraniLek.IzbrisaneJacine.Add(jacinaDelete);              //////////////////////////////////
            }
        }

    }
}
