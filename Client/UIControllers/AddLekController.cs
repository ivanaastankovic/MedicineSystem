using Client.Helpers;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UIControllers
{
    public class AddLekController
    {
        //public  List<OblikLeka> Oblici { get; set; }
        internal void SetComboBoxes(ComboBox cbGrupa, ComboBox cbProizvodjac, ComboBox cbOblik)
        {
            try
            {
                cbGrupa.DataSource = Communication.Communication.Instance.GetGrupe(new GrupaLekova());
                cbGrupa.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita grupe lekova.");
                return;
            }
            try
            {
                cbProizvodjac.DataSource = Communication.Communication.Instance.GetProizvodjaci(new ProizvodjacLekova());
                cbProizvodjac.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita proizvođače lekova.");
                return;
            }
            try
            {
                cbOblik.DataSource = Communication.Communication.Instance.GetOblici(new OblikLeka());
                cbOblik.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita oblike lekova.");
                return;
            }

        }

        internal void SaveLek(TextBox txtNaziv, TextBox txtMehanizam, TextBox txtTrajanjeTeparije, ComboBox cbGrupa, ComboBox cbProizvodjac, List<JacinaLeka> jacineLeka)
        {
            if (FormHelper.EmptyFieldValidation(txtNaziv) |
               FormHelper.EmptyFieldValidation(txtMehanizam) |
               FormHelper.EmptyFieldValidation(txtTrajanjeTeparije) |
               cbGrupa.SelectedItem == null |
               cbProizvodjac.SelectedItem == null)
            {
                MessageBox.Show("Sva polja su obavezna.");
                return;
            }

            if (!double.TryParse(txtTrajanjeTeparije.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("Trajanje terapije mora biti ceo broj ili u formatu /00.00/");
                return;
            }

            if (jacineLeka.Count < 1)
            {
                MessageBox.Show("Morate uneti najmanje jedan oblik leka.");
                return;
            }

            GrupaLekova grupaCB = (GrupaLekova)cbGrupa.SelectedItem;
            GrupaLekova grupa = new GrupaLekova
            {
                SelectWhere = $"where grupaid = {grupaCB.GrupaLekovaId}"
            };
            ProizvodjacLekova proizvodjacCB = (ProizvodjacLekova)cbProizvodjac.SelectedItem;
            ProizvodjacLekova proizvodjac = new ProizvodjacLekova
            {
                SelectWhere = $"where proizvodjacid={proizvodjacCB.ProizvodjacId}"
            };


            Lek lek = new Lek
            {
                NazivLeka = txtNaziv.Text,
                MehanizamDejstva = txtMehanizam.Text,
                TrajanjeTerapije = double.Parse(txtTrajanjeTeparije.Text),
                Grupa = Communication.Communication.Instance.GetGrupa(grupa),
                Proizvodjac = Communication.Communication.Instance.GetProizvodjac(proizvodjac),
                JacineLeka = jacineLeka
            };

            if (Communication.Communication.Instance.AddLek(lek))
            {
                MessageBox.Show("Sistem je zapamtio podatke o leku.");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti podatke o leku.");
            }
        }

        internal void FillObliciDGV(DataGridView dgvOblici, List<JacinaLeka> sveJacine, List<JacinaLeka> jacineOblika)
        {

            foreach (JacinaLeka jacinaLeka in jacineOblika)
            {
                sveJacine.Add(jacinaLeka);
            }
            dgvOblici.DataSource = null;
            dgvOblici.DataSource = new BindingList<JacinaLeka>(sveJacine);
        }

      
    }
}
