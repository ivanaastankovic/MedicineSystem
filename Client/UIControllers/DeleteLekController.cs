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
    public class DeleteLekController
    {
        BindingList<Lek> lekovi = new BindingList<Lek>();
        internal void SetComboBox(ComboBox cbCriteria)
        {
            cbCriteria.DataSource = new List<string>
            {
                "None",
                "ID",
                "Naziv",
                "Mehanizam dejstva",
                "Trajanje terapije",
                "Grupa lekova",
                "Proizvodjac"
            };
            cbCriteria.SelectedIndex = -1;
        }

        internal void GetLekoviDGV(DataGridView dgvLekovi, Lek lek)
        {
            dgvLekovi.DataSource = Communication.Communication.Instance.GetLekovi(lek);
        }

        internal void FindLekovi(ComboBox cbCriteria, TextBox txtValue, DataGridView dgvLekovi, Button btnDelete)
        {
            if (cbCriteria.SelectedItem != null && cbCriteria.SelectedItem.ToString() == "None")
            {
                txtValue.Enabled = false;
                lekovi = new BindingList<Lek>(Communication.Communication.Instance.GetLekovi(new Lek()));
            }
            else
            {
                if (FormHelper.EmptyFieldValidation(txtValue) |
                    cbCriteria.SelectedItem == null)
                {
                    MessageBox.Show("Odaberite kriterijum i unesite njegovu vrednost.");
                    return;
                }
                if (cbCriteria.SelectedItem.ToString() == "ID" && !int.TryParse(txtValue.Text, out _))
                {
                    MessageBox.Show("ID mora biti broj.");
                    return;
                }
                if (cbCriteria.SelectedItem.ToString() == "Trajanje terapije" && !double.TryParse(txtValue.Text, out _))
                {
                    MessageBox.Show("Trajanje terapije mora biti ceo ili decimalan broj.");
                    return;
                }
                Lek lek = CreateLek(txtValue.Text, cbCriteria.SelectedItem.ToString());
                lekovi = new BindingList<Lek>(Communication.Communication.Instance.GetLekovi(lek));
            }
            dgvLekovi.DataSource = lekovi;
            dgvLekovi.Columns[0].HeaderText = "ID";
            dgvLekovi.Columns[1].HeaderText = "Naziv";
            dgvLekovi.Columns[2].HeaderText = "Mehanizam dejstva";
            dgvLekovi.Columns[3].HeaderText = "Trajanje terapije";
            dgvLekovi.Columns[4].HeaderText = "Grupa";
            dgvLekovi.Columns[5].HeaderText = "Proizvođač";

            if (dgvLekovi.RowCount > 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sistem ne moze da pronađe lek sa zadatom vrednošću.");
                btnDelete.Enabled = false;
            }
        }

        internal void DeleteLek(DataGridView dgvLekovi, ComboBox cbCriteria)
        {
            if (dgvLekovi.SelectedRows.Count != 1)
            {
                MessageBox.Show("Izaberite jedan lek koji želite da obrišete.");

                return;
            }
            if (lekovi.Count == 0 | (cbCriteria.SelectedItem != null && cbCriteria.SelectedItem.ToString() == "None"))
            {
                lekovi = new BindingList<Lek>(Communication.Communication.Instance.GetLekovi(new Lek()));
            }
            Lek lekDelete = (Lek)dgvLekovi.SelectedRows[0].DataBoundItem;
            lekDelete.SelectWhere = $"where lekid = {lekDelete.LekId}";
            JacinaLeka jacina = new JacinaLeka();
            jacina.SelectWhere = $"where l.lekid={lekDelete.LekId}";
            
            List<JacinaLeka> jacineLeka = Communication.Communication.Instance.GetObliciLeka(jacina);
            lekDelete.JacineLeka = jacineLeka;
            if (Communication.Communication.Instance.DeleteLek(lekDelete))
            {
                Lek lek = lekovi.First(l => l.LekId == lekDelete.LekId);
                lekovi.Remove(lek);
                MessageBox.Show("Sistem je obrisao lek.");
                dgvLekovi.DataSource = null;
                dgvLekovi.DataSource = lekovi;
            }
            else
            {
                MessageBox.Show("Sistem ne može da obriše lek.");
            }
        }

        private Lek CreateLek(string value, string criteria)
        {
            Lek lek = new Lek();
            if (criteria == "ID")
            {
                lek.SelectWhere = $"where l.lekid={value}";
                return lek;
            }
            else if (criteria == "Naziv")
            {
                lek.SelectWhere = $"where l.nazivleka like '%{value}%'";
                return lek;
            }
            else if (criteria == "Mehanizam dejstva")
            {
                lek.SelectWhere = $"where l.mehanizamdejstva like '%{value}%'";
                return lek;
            }
            else if (criteria == "Trajanje terapije")
            {
                lek.SelectWhere = $"where l.trajanjeterapije={value}";
                return lek;
            }
            else if (criteria == "Grupa lekova")
            {
                lek.SelectWhere = $"where g.nazivgrupe like '%{value}%'";
                return lek;
            }
            else
            {
                lek.SelectWhere = $"where p.nazivproizvodjaca like '%{value}%'";
                return lek;
            }
        }
    }
}
