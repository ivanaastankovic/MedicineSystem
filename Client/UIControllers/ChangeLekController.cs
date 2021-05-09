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
    public class ChangeLekController
    {

        internal void SetComboBox(ComboBox cbCriteria)
        {
            cbCriteria.DataSource = new List<string>
            {
                "None",
                "Naziv",
                "Mehanizam dejstva",
                "Trajanje terapije",
                "Grupa",
                "Proizvodjac"
            };
        }

        internal void SetDGVData(DataGridView dgvLekovi)
        {
            dgvLekovi.DataSource = null;
            dgvLekovi.DataSource = Communication.Communication.Instance.GetLekovi(new Lek());
            dgvLekovi.Columns["LekId"].HeaderText = "ID";
            dgvLekovi.Columns["NazivLeka"].HeaderText = "Naziv";
            dgvLekovi.Columns["MehanizamDejstva"].HeaderText = "Mehanizam dejstva";
            dgvLekovi.Columns["TrajanjeTerapije"].HeaderText = "Trajanje terapije";
            dgvLekovi.Columns["NazivGrupe"].HeaderText = "Grupa";
            dgvLekovi.Columns["NazivProizvodjaca"].HeaderText = "Proizvođač";
        }

        internal void FindLekovi(ComboBox cbCriteria, TextBox txtValue, DataGridView dgvLekovi)
        {
            if (FormHelper.EmptyFieldValidation(txtValue) |
                cbCriteria.SelectedItem == null)
            {
                MessageBox.Show("Odaberite kriterijum i unesite njegovu vrednost.");
                return;
            }
            if (cbCriteria.SelectedItem.ToString() == "Trajanje terapije" && !double.TryParse(txtValue.Text, out _))
            {
                MessageBox.Show("Trajanje terapije mora biti ceo ili decimalan broj.");
                return;
            }
            Lek lek = CreateProizvodjac(cbCriteria.SelectedItem.ToString(), txtValue.Text);
            dgvLekovi.DataSource = null;
            dgvLekovi.DataSource = Communication.Communication.Instance.GetLekovi(lek);
            dgvLekovi.Columns["LekId"].HeaderText = "ID";
            dgvLekovi.Columns["NazivLeka"].HeaderText = "Naziv";
            dgvLekovi.Columns["MehanizamDejstva"].HeaderText = "Mehanizam dejstva";
            dgvLekovi.Columns["TrajanjeTerapije"].HeaderText = "Trajanje terapije";
            dgvLekovi.Columns["NazivGrupe"].HeaderText = "Grupa";
            dgvLekovi.Columns["NazivProizvodjaca"].HeaderText = "Proizvođač";

            if (dgvLekovi.RowCount > 0)
            {
                MessageBox.Show("Sistem je pronašao lekove po zadatoj vrednosti.");
            }
            else
            {
                MessageBox.Show("Sistem ne može da pronađe lekove po zadatoj vrednosti.");
            }
        }


        internal Lek FindLek(Lek lekDGV, DataGridView dgvLekovi)
        {
            if (dgvLekovi.SelectedRows.Count != 1)
            {
                MessageBox.Show("Izaberite jednu grupu lekova čije informacije želite da vidite.");
                return null;
            }
            lekDGV.SelectWhere = $"where l.lekid={lekDGV.LekId}";
            Lek lek = Communication.Communication.Instance.GetLekovi(lekDGV).First();   /// UcitajLek()
            lek.JacineLeka = new List<JacinaLeka>();
            return lek;
        }

        private Lek CreateProizvodjac(string criteria, string value)
        {
            Lek lek = new Lek();
            if (criteria == "Naziv")
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
            else if (criteria == "Grupa")
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
