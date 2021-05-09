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
    public partial class FrmGrupaLekova : Form
    {
        GrupaLekova izabranaGrupa;
        SearchGrupaController searchGrupaController ;
        public FrmGrupaLekova(GrupaLekova izabranaGrupa, SearchGrupaController searchGrupaController)
        {
            InitializeComponent();
            this.izabranaGrupa = izabranaGrupa;
            if (izabranaGrupa!=null)
            {
                this.searchGrupaController = searchGrupaController;
                lblGrupaLekova.Text = izabranaGrupa.NazivGrupe;
                searchGrupaController.GetLekoviGrupe(izabranaGrupa, dgvLekovi); 
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
