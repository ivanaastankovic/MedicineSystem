using Client.UIControllers;
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
    public partial class FrmDeleteGrupaLekova : Form
    {
        DeleteGrupaController deleteGrupaController = new DeleteGrupaController();
        public FrmDeleteGrupaLekova()
        {
            InitializeComponent();
            deleteGrupaController.SetComboBox(cbCriteria);
            deleteGrupaController.GetAllGrupe(dgvGrupe);
        }

        private void btnFindGrupe_Click(object sender, EventArgs e)
        {
            deleteGrupaController.ShowGrupeWhere(txtValue,cbCriteria,dgvGrupe, btnDelete);
         
        }

        private void cbCriteria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCriteria.SelectedItem.ToString() == "None")
            {
                txtValue.Enabled = false;
                deleteGrupaController.GetAllGrupe(dgvGrupe);
                btnFindGrupe.Enabled = false;
                return;
            }
            btnFindGrupe.Enabled = true;
            txtValue.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteGrupaController.DeleteGrupa(dgvGrupe, cbCriteria);
        }

        private void dgvGrupe_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
