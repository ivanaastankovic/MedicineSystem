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
    public partial class FrmLogin : Form
    {
        LoginController loginController = new LoginController();
        public FrmLogin()
        {
            
            InitializeComponent();
        }

        private void Connect()
        {
            if (!Communication.Communication.Instance.Connect())
            {
                MessageBox.Show("Neuspesno povezivanje sa serverom.");
                Environment.Exit(0);
            }
            return;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connect();
            if (loginController.Login(txtUsername, txtPassword))
            {
                
                FrmMain frmMain = new FrmMain();
                this.Visible = false;
                frmMain.ShowDialog();
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginController.LogOut();
        }
    }
}
