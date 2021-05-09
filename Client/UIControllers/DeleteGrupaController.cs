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
    public class DeleteGrupaController
    {
        BindingList<GrupaLekova> grupe = new BindingList<GrupaLekova>();
        internal void SetComboBox(ComboBox cbCriteria)
        {
            cbCriteria.DataSource = new List<string>() { "None", "ID", "Naziv" };
            cbCriteria.SelectedIndex = -1;
        }

        internal void ShowGrupeWhere(TextBox txtValue, ComboBox cbCriteria, DataGridView dgvGrupe, Button btnDelete)
        {
            if (cbCriteria.SelectedItem != null && cbCriteria.SelectedItem.ToString() == "None")
            {
                txtValue.Enabled = false;
                grupe = new BindingList<GrupaLekova>(Communication.Communication.Instance.GetGrupe(new GrupaLekova()));
            }
            else
            {
                if (cbCriteria.SelectedItem == null | FormHelper.EmptyFieldValidation(txtValue))
                {
                    MessageBox.Show("Odaberite kriterijum i unesite njegovu vrednost.");
                    return;
                }
                if (cbCriteria.SelectedItem.ToString() == "ID" && !int.TryParse(txtValue.Text, out _))
                {
                    MessageBox.Show("ID mora biti broj.");
                    return;
                }
                GrupaLekova grupaLekova = CreateGrupa(cbCriteria.SelectedItem.ToString(), txtValue.Text);
                grupe = new BindingList<GrupaLekova>(Communication.Communication.Instance.GetGrupe(grupaLekova));
            }
            dgvGrupe.DataSource = grupe;
            dgvGrupe.Columns["GrupaLekovaId"].HeaderText = "ID";
            dgvGrupe.Columns["NazivGrupe"].HeaderText = "Naziv";

            if (dgvGrupe.RowCount > 0)
            {
                MessageBox.Show("Sistem je pronašao grupe lekova po zadatoj vrednosti.");
                btnDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sistem ne može da pronađe grupe lekova po zadatoj vrednosti.");
                btnDelete.Enabled = false;
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

        internal void DeleteGrupa(DataGridView dgvGrupe, ComboBox cbCriteria)
        {
            if (dgvGrupe.SelectedRows.Count != 1)
            {
                MessageBox.Show("Izaberite jednu grupu koji želite da obrišete.");
                return;
            }

            if (grupe.Count == 0 | (cbCriteria.SelectedItem != null && cbCriteria.SelectedItem.ToString() == "None"))
            {
                grupe = new BindingList<GrupaLekova>(Communication.Communication.Instance.GetGrupe(new GrupaLekova()));
            }
            GrupaLekova grupaDelete = (GrupaLekova)dgvGrupe.SelectedRows[0].DataBoundItem;
            grupaDelete.SelectWhere = $"where grupaid={grupaDelete.GrupaLekovaId}";

            if (Communication.Communication.Instance.DeleteGrupa(grupaDelete))
            {
                GrupaLekova grupaLekova = grupe.First(g => g.GrupaLekovaId == grupaDelete.GrupaLekovaId);
                grupe.Remove(grupaLekova);
                dgvGrupe.DataSource = null;
                dgvGrupe.DataSource = grupe;
                MessageBox.Show("Sistem je obrisao grupu lekova.");
            }
            else
            {
                MessageBox.Show("Sistem ne može da obriše grupu lekova.");
            }
        }

        private GrupaLekova CreateGrupa(string criteria, string value)
        {
            GrupaLekova grupaLekova = new GrupaLekova();
            if (criteria == "ID")
            {
                grupaLekova.SelectWhere = $"where grupaid={int.Parse(value)}";
            }
            else
            {
                grupaLekova.SelectWhere = $"where nazivgrupe like '%{value}%'";
            }
            return grupaLekova;
        }
    }
}
