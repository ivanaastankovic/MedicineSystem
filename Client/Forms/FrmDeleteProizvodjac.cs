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
    public partial class FrmDeleteProizvodjac : Form
    {
        DeleteProizvodjacController deleteProizvodjacController = new DeleteProizvodjacController();
        public FrmDeleteProizvodjac()
        {
            InitializeComponent();
            deleteProizvodjacController.SetComboBox(cbCriteria);
            deleteProizvodjacController.GetAllProizvodjaci(dgvProizvodjaci,new ProizvodjacLekova());
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            deleteProizvodjacController.ShowProizvodjaciWhere(cbCriteria, txtValue, dgvProizvodjaci, btnDelete);
        }
        private void cbCriteria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCriteria.SelectedItem.ToString() == "None")
            {
                txtValue.Enabled = false;
                deleteProizvodjacController.GetAllProizvodjaci(dgvProizvodjaci, new ProizvodjacLekova());
                btnShow.Enabled = false;
                return;
            }
            btnShow.Enabled = true;
            txtValue.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteProizvodjacController.DeleteProizvodjac(dgvProizvodjaci, cbCriteria);
        }

        private void dgvProizvodjaci_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
