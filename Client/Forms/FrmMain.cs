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
    public partial class FrmMain : Form
    {
        MainFormController mainFormController = new MainFormController();
        public FrmMain()
        {
            InitializeComponent();
            lblKorisnik.Text = $"{Communication.Communication.PrijavljeniKorisnik.Ime} {Communication.Communication.PrijavljeniKorisnik.Prezime}";
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainFormController.LogOut();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            mainFormController.LogOut();
            this.Dispose();
        }


        private void btnAddGrupa_Click(object sender, EventArgs e)
        {
            FrmAddGrupaLekova frmAddGrupaLekova = new FrmAddGrupaLekova();
            this.Visible = false;
            frmAddGrupaLekova.ShowDialog();
            this.Visible = true;
        }


        private void btnSearchGrupa_Click(object sender, EventArgs e)
        {
            FrmSearchGrupa frmSearchGrupa = new FrmSearchGrupa();
            this.Visible = false;
            frmSearchGrupa.ShowDialog();
            this.Visible = true;
        }

        private void btnDeleteGrupa_Click(object sender, EventArgs e)
        {
            FrmDeleteGrupaLekova frmDeleteGrupaLekova = new FrmDeleteGrupaLekova();
            this.Visible = false;
            frmDeleteGrupaLekova.ShowDialog();
            this.Visible = true;
        }

        private void btnAddProizvodjac_Click(object sender, EventArgs e)
        {
            FrmAddProizvodjacLekova frmAddProizvodjacLekova = new FrmAddProizvodjacLekova();
            this.Visible = false;
            frmAddProizvodjacLekova.ShowDialog();
            this.Visible = true;
        }
        private void btnSearchProizvodjac_Click(object sender, EventArgs e)
        {
            FrmSearchProizvodjac frmSearchProizvodjac = new FrmSearchProizvodjac();
            this.Visible = false;
            frmSearchProizvodjac.ShowDialog();
            this.Visible = true;
        }

        private void btnDeleteProizvodjac_Click(object sender, EventArgs e)
        {
            FrmDeleteProizvodjac frmDeleteProizvodjac = new FrmDeleteProizvodjac();
            this.Visible = false;
            frmDeleteProizvodjac.ShowDialog();
            this.Visible = true;
        }

        private void btnAddLek_Click(object sender, EventArgs e)
        {
            FrmAddLek frmAddLek = new FrmAddLek();
            this.Visible = false;
            frmAddLek.ShowDialog();
            this.Visible = true;
        }

        private void btnChangeLek_Click(object sender, EventArgs e)
        {
            FrmChangeLek frmChangeLek = new FrmChangeLek();
            this.Visible = false;
            frmChangeLek.ShowDialog();
            this.Visible = true;
        }

        private void btnDeleteLek_Click(object sender, EventArgs e)
        {
            FrmDeleteLek frmDeleteLek = new FrmDeleteLek();
            this.Visible = false;
            frmDeleteLek.ShowDialog();
            this.Visible = true;
        }
    }
}
