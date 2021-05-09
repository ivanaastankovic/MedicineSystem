using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        Server server;

        public FrmServer()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            label1.Text = "Server nije pokrenut";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                server = new Server();
                Thread thread = new Thread(server.Start);
                thread.IsBackground = true;
                thread.Start();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                label1.Text = "Server je pokrenut";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.Stop())
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                label1.Text = "Server nije pokrenut";
            }
            else
            {
                MessageBox.Show("Server se ne može isključiti. Postoje konektovani klijenti.");

            }
        }
    }
}
