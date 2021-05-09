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
    public partial class FrmChangeSelectedLek : Form
    {
        Lek izabraniLek;
        public Lek NoviLek { get; set; }
        ChangeSelectedLekController ChangeSelectedLekController = new ChangeSelectedLekController();
        public FrmChangeSelectedLek(Lek izabraniLek)
        {
            InitializeComponent();
            this.izabraniLek = izabraniLek;
            NoviLek = izabraniLek;
            if (izabraniLek != null)
            {
                lblSelectedLek.Text = izabraniLek.NazivLeka;
                ChangeSelectedLekController.FillForm(txtMehanizam, txtTrajanjeTerapije, dgvJacine, cbOblik, izabraniLek);
            }
            else
            {
                throw new Exception();
            }
        }

        private void cbOblik_SelectionChangeCommitted(object sender, EventArgs e)
        {

            ChangeSelectedLekController.setDGVJacine(dgvJacine, cbOblik, izabraniLek, btnAddOblik);
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
            ChangeSelectedLekController.FillSveJacine(frmAddJacinaLeka.JacineOblika, izabraniLek);
            ChangeSelectedLekController.setDGVJacine(dgvJacine, cbOblik, izabraniLek, btnAddOblik);
        }

        private void btnDeleteOblik_Click(object sender, EventArgs e)
        {
            ChangeSelectedLekController.DeleteOblik(dgvJacine, izabraniLek);
            ChangeSelectedLekController.setDGVJacine(dgvJacine, cbOblik, izabraniLek, btnAddOblik);
        }

        private void btnChangeOblik_Click(object sender, EventArgs e)
        {
            if (dgvJacine.SelectedRows.Count != 1)
            {
                MessageBox.Show("Izaberite jedan oblik koji želite da izmenite.");
                return;
            }
            try
            {
                FrmChangeOblikLeka frmChangeOblikLeka = new FrmChangeOblikLeka((JacinaLeka)dgvJacine.SelectedRows[0].DataBoundItem, izabraniLek);
                this.Visible = false;
                frmChangeOblikLeka.ShowDialog();
                this.Visible = true;

                ChangeSelectedLekController.ChangeJacina(frmChangeOblikLeka.IzmenjenaJacina, dgvJacine, izabraniLek);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Lek lek = ChangeSelectedLekController.SaveChanges(izabraniLek, txtMehanizam, txtTrajanjeTerapije, dgvJacine);
            if (lek != null)
            {
                ChangeSelectedLekController.UpdateLek(lek);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti lek.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
