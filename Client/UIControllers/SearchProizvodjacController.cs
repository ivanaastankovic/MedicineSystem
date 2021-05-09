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
    public class SearchProizvodjacController
    {
        //BindingList<ProizvodjacLekova> proizvodjaci = new BindingList<ProizvodjacLekova>();
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

        internal void ShowProizvodjaciWhere(TextBox txtValue, ComboBox cbCriteria, DataGridView dgvProizvodjaci, Button btnInfo)
        {
            if (FormHelper.EmptyFieldValidation(txtValue) | cbCriteria.SelectedItem == null)
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
            GetAllProizvodjaci(dgvProizvodjaci, proizvodjacLekova);
            if (dgvProizvodjaci.RowCount > 0)
            {
                MessageBox.Show("Sistem je pronašao proizvođače lekova po zadatoj vrednosti.");
                btnInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sistem ne može da pronađe proizvođače lekova po zadatoj vrednosti.");
                btnInfo.Enabled = false;
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
            else
            {
                proizvodjacLekova.SelectWhere = $"where adresa like '%{value}%'";
                return proizvodjacLekova;
            }
        }

        internal ProizvodjacLekova FindProizvodjacLekova(ProizvodjacLekova izabraniProizvodjacDGV, DataGridView dgvProizvodjaci)
        {
            if (dgvProizvodjaci.SelectedRows.Count != 1)
            {
                MessageBox.Show("Izaberite jednog proizvođača lekova čije informacije želite da vidite.");
                return null;
            }
            izabraniProizvodjacDGV.SelectWhere = $"where proizvodjacid={izabraniProizvodjacDGV.ProizvodjacId}";
            return Communication.Communication.Instance.GetProizvodjac(izabraniProizvodjacDGV);
        }

        internal void GetLekoviProizvodjaca(ProizvodjacLekova izabraniProizvodjac, DataGridView dgvLekovi)
        {
            Lek lek = new Lek
            {
                Proizvodjac = izabraniProizvodjac,
                SelectWhere = $"where {izabraniProizvodjac.AliasName}.proizvodjacid ={izabraniProizvodjac.ProizvodjacId}"

            };
            dgvLekovi.DataSource = Communication.Communication.Instance.GetLekoviProizvodjaca(lek);
            dgvLekovi.Columns[0].HeaderText = "ID";
            dgvLekovi.Columns[1].HeaderText = "Naziv leka";
            dgvLekovi.Columns[2].HeaderText = "Mehanizam dejstva";
            dgvLekovi.Columns[3].HeaderText = "Trajanje terapije";
            dgvLekovi.Columns[4].HeaderText = "Grupa";
            dgvLekovi.Columns[5].HeaderText = "Proizvođač";

        }
    }
}
