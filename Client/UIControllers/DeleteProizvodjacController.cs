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
    public class DeleteProizvodjacController
    {
        BindingList<ProizvodjacLekova> proizvodjaci = new BindingList<ProizvodjacLekova>();
        internal void SetComboBox(ComboBox cbCriteria)
        {
            cbCriteria.DataSource = new List<string>()
            {
                "None",
                 "ID",
                "Naziv",
                "Godina osnivanja",
                "Vlasnik",
                "Adresa"
            };
            cbCriteria.SelectedIndex = -1;
        }

        internal void GetAllProizvodjaci(DataGridView dgvProizvodjaci, ProizvodjacLekova proizvodjac)
        {
            dgvProizvodjaci.DataSource = Communication.Communication.Instance.GetProizvodjaci(proizvodjac);
            dgvProizvodjaci.Columns["ProizvodjacId"].HeaderText = "ID";
            dgvProizvodjaci.Columns["NazivProizvodjaca"].HeaderText = "Naziv";
            dgvProizvodjaci.Columns["GodinaOsnivanja"].HeaderText = "Godina osnivanja";
            dgvProizvodjaci.Columns["ImePrezimeVlasnika"].HeaderText = "Vlasnik";
        }

        internal void ShowProizvodjaciWhere(ComboBox cbCriteria, TextBox txtValue, DataGridView dgvProizvodjaci, Button btnDelete)
        {
            if (cbCriteria.SelectedItem != null && cbCriteria.SelectedItem.ToString() == "None")
            {
                txtValue.Enabled = false;
                proizvodjaci = new BindingList<ProizvodjacLekova>(Communication.Communication.Instance.GetProizvodjaci(new ProizvodjacLekova()));
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
                if (cbCriteria.SelectedItem.ToString() == "Godina osnivanja" && !int.TryParse(txtValue.Text, out _))
                {
                    MessageBox.Show("Godina osnivanja mora biti broj.");
                    return;
                }
                ProizvodjacLekova proizvodjacLekova = CreateProizvodjac(txtValue.Text, cbCriteria.SelectedItem.ToString());
                proizvodjaci = new BindingList<ProizvodjacLekova>(Communication.Communication.Instance.GetProizvodjaci(proizvodjacLekova));
            }

            dgvProizvodjaci.DataSource = proizvodjaci;
            dgvProizvodjaci.Columns["ProizvodjacId"].HeaderText = "ID";
            dgvProizvodjaci.Columns["NazivProizvodjaca"].HeaderText = "Naziv";
            dgvProizvodjaci.Columns["GodinaOsnivanja"].HeaderText = "Godina osnivanja";
            dgvProizvodjaci.Columns["ImePrezimeVlasnika"].HeaderText = "Vlasnik";

            if (dgvProizvodjaci.RowCount > 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sistem ne moze da pronađe proizvođače lekova sa zadatom vrednošću.");
                btnDelete.Enabled = false;
            }

        }


        private ProizvodjacLekova CreateProizvodjac(string value, string criteria)
        {
            ProizvodjacLekova proizvodjacLekova = new ProizvodjacLekova();
            if (criteria == "ID")
            {
                proizvodjacLekova.SelectWhere = $"where proizvodjacid={value}";
                return proizvodjacLekova;
            }
            else if (criteria == "Naziv")
            {
                proizvodjacLekova.SelectWhere = $"where nazivproizvodjaca like '%{value}%'";
                return proizvodjacLekova;
            }
            else if (criteria == "Godina osnivanja")
            {
                proizvodjacLekova.SelectWhere = $"where godinaosnivanja = {value}";
                return proizvodjacLekova;
            }
            else if (criteria == "Vlasnik")
            {
                proizvodjacLekova.SelectWhere = $"where imeprezimevlasnika like '%{value}%'";
                return proizvodjacLekova;
            }
            {
                proizvodjacLekova.SelectWhere = $"where adresa like '%{value}%'";
                return proizvodjacLekova;
            }
        }
        internal void DeleteProizvodjac(DataGridView dgvProizvodjaci, ComboBox cbCriteria)
        {
            if (dgvProizvodjaci.SelectedRows.Count != 1)
            {
                MessageBox.Show("Izaberite jednog proizvođača kojeg želite da obrišete.");
                return;
            }
            if (proizvodjaci.Count == 0 | (cbCriteria.SelectedItem != null && cbCriteria.SelectedItem.ToString() == "None"))
            {
                proizvodjaci = new BindingList<ProizvodjacLekova>(Communication.Communication.Instance.GetProizvodjaci(new ProizvodjacLekova()));
            }
            ProizvodjacLekova proizvodjacDelete = (ProizvodjacLekova)dgvProizvodjaci.SelectedRows[0].DataBoundItem;
            proizvodjacDelete.SelectWhere = $"where proizvodjacid = {proizvodjacDelete.ProizvodjacId}";
            if (Communication.Communication.Instance.DeleteProizvodjac(proizvodjacDelete))
            {
                ProizvodjacLekova proizvodjac = proizvodjaci.First(p => p.ProizvodjacId == proizvodjacDelete.ProizvodjacId);
                proizvodjaci.Remove(proizvodjac);
                dgvProizvodjaci.DataSource = null;
                dgvProizvodjaci.DataSource = proizvodjaci;
                MessageBox.Show("Sistem je obrisao proizvođača lekova.");
            }
            else
            {
                MessageBox.Show("Sistem ne može da obriše proizvođača lekova.");
            }

        }
    }
}
