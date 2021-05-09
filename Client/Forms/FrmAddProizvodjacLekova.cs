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
    public partial class FrmAddProizvodjacLekova : Form
    {
        AddProizvodjacController addProizvodjacController = new AddProizvodjacController();
        public FrmAddProizvodjacLekova()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addProizvodjacController.Save(txtNaziv, txtGodina, txtImePrezime, txtAdresa))
            {
                MessageBox.Show("Sistem je zapamtio proizvođača lekova.");
                return;
            }
            MessageBox.Show("Sistem ne može da zapamti proizvođača lekova.");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
