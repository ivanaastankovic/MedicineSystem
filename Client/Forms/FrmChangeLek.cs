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
    public partial class FrmChangeLek : Form
    {
        ChangeLekController changeLekController = new ChangeLekController();
        public FrmChangeLek()
        {
            InitializeComponent();
            changeLekController.SetComboBox(cbCriteria);
            changeLekController.SetDGVData(dgvLekovi);
        }

        private void cbCriteria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCriteria.SelectedItem.ToString() == "None")
            {
                txtValue.Enabled = false;
                changeLekController.SetDGVData(dgvLekovi);
                btnFind.Enabled = false;
                return;
            }
            btnFind.Enabled = true;
            txtValue.Enabled = true;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            changeLekController.FindLekovi(cbCriteria, txtValue, dgvLekovi);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                Lek izabraniLek = changeLekController.FindLek((Lek)dgvLekovi.SelectedRows[0].DataBoundItem, dgvLekovi);

                FrmChangeSelectedLek frmChangeSelectedLek = new FrmChangeSelectedLek(izabraniLek);
                this.Visible = false;
                frmChangeSelectedLek.ShowDialog();
                this.Visible = true;
                changeLekController.SetDGVData(dgvLekovi);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Izaberite jednu grupu lekova čije informacije želite da vidite.");

                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita podatke o lekovima po zadatoj vrednosti.");
                return;
            }
        }
    }
}
