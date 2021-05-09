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
    public partial class FrmAddLek : Form
    {
        AddLekController addLekController = new AddLekController();
        List<JacinaLeka> sveJacine = new List<JacinaLeka>();
        public FrmAddLek()
        {
            InitializeComponent();
            addLekController.SetComboBoxes(cbGrupa, cbProizvodjac, cbOblik);
            dgvOblici.DataSource = new BindingList<JacinaLeka>(sveJacine);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addLekController.SaveLek(txtNaziv, txtMehanizam, txtTrajanjeTeparije, cbGrupa, cbProizvodjac, sveJacine);

        }


        private void btnAddOblik_Click(object sender, EventArgs e)
        {
            if (cbOblik.SelectedItem == null)
            {
                MessageBox.Show("Izaberite oblik leka.");
                return;
            }
            FrmAddJacinaLeka frmAddJacinaLeka = new FrmAddJacinaLeka((OblikLeka)cbOblik.SelectedItem);
            this.Visible = false;
            frmAddJacinaLeka.ShowDialog();
            this.Visible = true;
            dgvOblici.DataSource = null;
            addLekController.FillObliciDGV(dgvOblici, sveJacine, frmAddJacinaLeka.JacineOblika);

        }
    }
}
