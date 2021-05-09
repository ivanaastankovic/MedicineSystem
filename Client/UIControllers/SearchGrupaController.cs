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
    public class SearchGrupaController
    {
        internal void SetComboBox(ComboBox cbCriteria)
        {
            cbCriteria.DataSource = new List<string>() { "None", "Naziv", "ID" };
            cbCriteria.SelectedIndex = -1;
        }

        internal void ShowGrupeWhere(ComboBox cbCriteria, TextBox txtValue, DataGridView dgvGrupe, Button btnInfo)
        {
          
            if (FormHelper.EmptyFieldValidation(txtValue) |
                cbCriteria.SelectedItem == null)
            {
                MessageBox.Show("Odaberite kriterijum i unesite njegovu vrednost.");
                return;
            }
            if (cbCriteria.SelectedItem.ToString() == "ID" && !int.TryParse(txtValue.Text, out _))
            {
                MessageBox.Show("ID mora biti broj");
                return;
            }
            GrupaLekova grupaLekova = CreateGrupa(cbCriteria, txtValue);
            dgvGrupe.DataSource = Communication.Communication.Instance.GetGrupe(grupaLekova);
            dgvGrupe.Columns["GrupaLekovaId"].HeaderText = "ID";
            dgvGrupe.Columns["NazivGrupe"].HeaderText = "Naziv";

            if (dgvGrupe.RowCount > 0)
            {
                btnInfo.Enabled = true;
                MessageBox.Show("Sistem je našao grupe lekova po zadatoj vrednosti.");
            }
            else
            {
                MessageBox.Show("Sistem ne može da pronađe grupe lekova po zadatoj vrednosti.");
                btnInfo.Enabled = false;
            }
        }

        internal void GetAllGrupe(DataGridView dgvGrupe)
        {
            try
            {
                dgvGrupe.DataSource = Communication.Communication.Instance.GetGrupe(new GrupaLekova());
                dgvGrupe.Columns["GrupaLekovaId"].HeaderText = "ID";
                dgvGrupe.Columns["NazivGrupe"].HeaderText = "Naziv";
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita grupe lekova.");
            }
        }

        private GrupaLekova CreateGrupa(ComboBox cbCriteria, TextBox txtValue)
        {
            GrupaLekova grupaLekova = new GrupaLekova();
            if (cbCriteria.SelectedItem.ToString() == "ID")
            {
                grupaLekova.SelectWhere = $"where GrupaID like {int.Parse(txtValue.Text)}";
                return grupaLekova;
            }
            else
            {
                grupaLekova.SelectWhere = $"where NazivGrupe like '%{txtValue.Text}%'";
                return grupaLekova;
            }
        }

        internal GrupaLekova FindGrupaLekova(GrupaLekova izabranaGrupaDGV, DataGridView dgvGrupe)
        {

            if (dgvGrupe.SelectedRows.Count != 1)
            {
                MessageBox.Show("Izaberite jednu grupu lekova čije informacije želite da vidite.");
                return null;
            }
            izabranaGrupaDGV.SelectWhere = $"where grupaid={izabranaGrupaDGV.GrupaLekovaId}";
            return Communication.Communication.Instance.GetGrupa(izabranaGrupaDGV);
        }

        internal void GetLekoviGrupe(GrupaLekova izabranaGrupa, DataGridView dgvLekovi)
        {
            Lek lek = new Lek
            {
                Grupa = izabranaGrupa,
                SelectWhere = $"where {izabranaGrupa.AliasName}.grupaid ={izabranaGrupa.GrupaLekovaId}"
                // GrupaNaziv = izabranaGrupa.NazivGrupe,

            };
            dgvLekovi.DataSource = Communication.Communication.Instance.GetLekoviGrupe(lek);
            dgvLekovi.Columns[0].HeaderText = "ID";
            dgvLekovi.Columns[1].HeaderText = "Naziv leka";
            dgvLekovi.Columns[2].HeaderText = "Mehanizam dejstva";
            dgvLekovi.Columns[3].HeaderText = "Trajanje terapije";
            dgvLekovi.Columns[4].HeaderText = "Grupa";
            dgvLekovi.Columns[5].HeaderText = "Proizvođač";


        }
    }
}
