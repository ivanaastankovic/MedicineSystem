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
    public partial class FrmAddJacinaLeka : Form
    {
        AddJacinaLekaController AddJacinaLekaController;
        public List<JacinaLeka> JacineOblika { get; set; } = new List<JacinaLeka>();
        public FrmAddJacinaLeka(OblikLeka oblikLeka)
        {
            InitializeComponent();
            txtOblik.Text = oblikLeka.NazivOblika;
            AddJacinaLekaController = new AddJacinaLekaController(oblikLeka);
            AddJacinaLekaController.SetComboBox(cbJedinicaMere);
        }

        private void btnAddJacina_Click(object sender, EventArgs e)
        {
            AddJacinaLekaController.SaveJacina(txtJacina, txtBoja, cbJedinicaMere, dgvJacine);
        }

        private void btnDeleteJacina_Click(object sender, EventArgs e)
        {
            AddJacinaLekaController.RemoveJacina(dgvJacine);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (dgvJacine.Rows.Count == 0)
            {
                MessageBox.Show("Morate uneti najmanje jednu jačinu leka");
                return;
            }
            JacineOblika = AddJacinaLekaController.GetJacine();
            this.Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
