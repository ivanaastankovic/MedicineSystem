using Client.UIControllers;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmSearchGrupa : Form
    {
        SearchGrupaController searchGrupaController = new SearchGrupaController();
        public FrmSearchGrupa()
        {
            InitializeComponent();
            searchGrupaController.SetComboBox(cbCriteria);
            searchGrupaController.GetAllGrupe(dgvGrupe);
        }

        private void cbCriteria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCriteria.SelectedItem.ToString() == "None")
            {
                txtValue.Enabled = false;
                searchGrupaController.GetAllGrupe(dgvGrupe);
                btnShow.Enabled = false;
                return;
            }
            btnShow.Enabled = true;
            txtValue.Enabled = true;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            searchGrupaController.ShowGrupeWhere(cbCriteria, txtValue, dgvGrupe, btnInfo);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            try
            {

                GrupaLekova izabranaGrupa = searchGrupaController.FindGrupaLekova((GrupaLekova)dgvGrupe.SelectedRows[0].DataBoundItem, dgvGrupe);
                FrmGrupaLekova frmGrupaLekova = new FrmGrupaLekova(izabranaGrupa, searchGrupaController);
                this.Visible = false;
                MessageBox.Show("Sistem je učitao grupu lekova.");
                frmGrupaLekova.ShowDialog();
                this.Visible = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Izaberite jednu grupu lekova čije informacije želite da vidite.");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita podatke o grupi lekova po zadatoj vrednosti.");
                return;
            }
        }

        private void dgvGrupe_SelectionChanged(object sender, EventArgs e)
        {
            btnInfo.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
