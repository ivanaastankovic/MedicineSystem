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
    public partial class FrmSearchProizvodjac : Form
    {
        SearchProizvodjacController searchProizvodjacController = new SearchProizvodjacController();
        public FrmSearchProizvodjac()
        {
            InitializeComponent();
            searchProizvodjacController.GetAllProizvodjaci(dgvProizvodjaci, new ProizvodjacLekova());
        }

        private void FrmSearchProizvodjac_Load(object sender, EventArgs e)
        {
            searchProizvodjacController.SetComboBox(cbCriteria);
        }

        private void cbCriteria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCriteria.SelectedItem.ToString() == "None")
            {
                txtValue.Enabled = false;
                searchProizvodjacController.GetAllProizvodjaci(dgvProizvodjaci, new ProizvodjacLekova());
                btnShow.Enabled = false;
                return;
            }
            btnShow.Enabled = true;
            txtValue.Enabled = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            searchProizvodjacController.ShowProizvodjaciWhere(txtValue, cbCriteria, dgvProizvodjaci, btnInfo);
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            try
            {

                ProizvodjacLekova izabraniProizvodjac = searchProizvodjacController.FindProizvodjacLekova((ProizvodjacLekova)dgvProizvodjaci.SelectedRows[0].DataBoundItem,dgvProizvodjaci);
                FrmProizvodjacLekova frmProizvodjacLekova = new FrmProizvodjacLekova(izabraniProizvodjac, searchProizvodjacController);
                this.Visible = false;
                MessageBox.Show("Sistem je učitao proizvođača lekova.");
                frmProizvodjacLekova.ShowDialog();
                this.Visible = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Izaberite jednog proizvođača čije informacije želite da vidite.");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita podatke o proizvođaču lekova.");
                return;
            }
        }

        private void dgvProizvodjaci_SelectionChanged(object sender, EventArgs e)
        {
            btnInfo.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
