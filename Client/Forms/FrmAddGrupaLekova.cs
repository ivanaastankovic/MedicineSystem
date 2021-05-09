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
    public partial class FrmAddGrupaLekova : Form
    {
        AddGrupaController addGrupaController = new AddGrupaController();
        public FrmAddGrupaLekova()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addGrupaController.Save(txtName))
            {
                MessageBox.Show("Sistem je zapamtio grupu lekova.");
                return;
            }

            MessageBox.Show("Sistem ne može da zapamti grupu lekova.");
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

