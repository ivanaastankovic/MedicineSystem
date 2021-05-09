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
    public partial class FrmDeleteLek : Form
    {
        DeleteLekController deleteLekController = new DeleteLekController();
        public FrmDeleteLek()
        {
            InitializeComponent();
            deleteLekController.SetComboBox(cbCriteria);
            deleteLekController.GetLekoviDGV(dgvLekovi, new Lek());
        }

        private void cbCriteria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCriteria.SelectedItem.ToString() == "None")
            {
                txtValue.Enabled = false;
                btnFind.Enabled = false;
                deleteLekController.GetLekoviDGV(dgvLekovi, new Lek());
                return;
            }
            btnFind.Enabled = true;
            txtValue.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            deleteLekController.FindLekovi(cbCriteria, txtValue, dgvLekovi, btnDelete);
        }

        private void dgvLekovi_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteLekController.DeleteLek(dgvLekovi, cbCriteria);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
