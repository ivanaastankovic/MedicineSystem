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
    public partial class FrmProizvodjacLekova : Form
    {
        ProizvodjacLekova izabraniProizvodjac;
        SearchProizvodjacController searchProizvodjacController;
        public FrmProizvodjacLekova(ProizvodjacLekova izabraniProizvodjac, SearchProizvodjacController searchProizvodjacController)
        {
            InitializeComponent();
            this.izabraniProizvodjac = izabraniProizvodjac;
            if (izabraniProizvodjac != null)
            {
                this.searchProizvodjacController = searchProizvodjacController;
                lblProizvodjacLekova.Text = izabraniProizvodjac.NazivProizvodjaca;
                searchProizvodjacController.GetLekoviProizvodjaca(izabraniProizvodjac, dgvLekovi);
            }
            else
            {
                throw new Exception();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
