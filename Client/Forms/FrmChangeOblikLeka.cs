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
    public partial class FrmChangeOblikLeka : Form
    {
        ChangeOblikLekaController changeOblikLekaController = new ChangeOblikLekaController();
        Lek izabraniLek;
        JacinaLeka izabranaJacina;
        public JacinaLeka IzmenjenaJacina { get; set; }
        public FrmChangeOblikLeka(JacinaLeka izabranaJacinaLeka, Lek izabraniLek)
        {
            InitializeComponent();
            this.izabraniLek = izabraniLek;
            this.izabranaJacina = izabranaJacinaLeka;
            changeOblikLekaController.SetComboBox(cbJedinicaMere);
            changeOblikLekaController.SetUIData(lblLekOblik, txtJacina, cbJedinicaMere, txtBoja, izabranaJacina, izabraniLek);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (changeOblikLekaController.SaveChanges(txtJacina, cbJedinicaMere, txtBoja, izabraniLek, izabranaJacina) != null)
            {
                IzmenjenaJacina = changeOblikLekaController.SaveChanges(txtJacina, cbJedinicaMere, txtBoja, izabraniLek, izabranaJacina);
                this.Dispose();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
