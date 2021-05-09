namespace Client.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteGrupa = new System.Windows.Forms.Button();
            this.btnSearchGrupa = new System.Windows.Forms.Button();
            this.btnAddGrupa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteLek = new System.Windows.Forms.Button();
            this.btnChangeLek = new System.Windows.Forms.Button();
            this.btnAddLek = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteProizvodjac = new System.Windows.Forms.Button();
            this.btnSearchProizvodjac = new System.Windows.Forms.Button();
            this.btnAddProizvodjac = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btnDeleteGrupa);
            this.panel1.Controls.Add(this.btnSearchGrupa);
            this.panel1.Controls.Add(this.btnAddGrupa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 425);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteGrupa
            // 
            this.btnDeleteGrupa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteGrupa.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGrupa.Location = new System.Drawing.Point(30, 291);
            this.btnDeleteGrupa.Name = "btnDeleteGrupa";
            this.btnDeleteGrupa.Size = new System.Drawing.Size(196, 47);
            this.btnDeleteGrupa.TabIndex = 3;
            this.btnDeleteGrupa.Text = "Brisanje";
            this.btnDeleteGrupa.UseVisualStyleBackColor = false;
            this.btnDeleteGrupa.Click += new System.EventHandler(this.btnDeleteGrupa_Click);
            // 
            // btnSearchGrupa
            // 
            this.btnSearchGrupa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchGrupa.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGrupa.Location = new System.Drawing.Point(30, 185);
            this.btnSearchGrupa.Name = "btnSearchGrupa";
            this.btnSearchGrupa.Size = new System.Drawing.Size(196, 47);
            this.btnSearchGrupa.TabIndex = 2;
            this.btnSearchGrupa.Text = "Pretraga";
            this.btnSearchGrupa.UseVisualStyleBackColor = false;
            this.btnSearchGrupa.Click += new System.EventHandler(this.btnSearchGrupa_Click);
            // 
            // btnAddGrupa
            // 
            this.btnAddGrupa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddGrupa.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrupa.Location = new System.Drawing.Point(30, 79);
            this.btnAddGrupa.Name = "btnAddGrupa";
            this.btnAddGrupa.Size = new System.Drawing.Size(196, 47);
            this.btnAddGrupa.TabIndex = 1;
            this.btnAddGrupa.Text = "Unos";
            this.btnAddGrupa.UseVisualStyleBackColor = false;
            this.btnAddGrupa.Click += new System.EventHandler(this.btnAddGrupa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupe lekova";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnDeleteLek);
            this.panel2.Controls.Add(this.btnChangeLek);
            this.panel2.Controls.Add(this.btnAddLek);
            this.panel2.Location = new System.Drawing.Point(271, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 425);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lekovi";
            // 
            // btnDeleteLek
            // 
            this.btnDeleteLek.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteLek.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLek.Location = new System.Drawing.Point(33, 292);
            this.btnDeleteLek.Name = "btnDeleteLek";
            this.btnDeleteLek.Size = new System.Drawing.Size(196, 47);
            this.btnDeleteLek.TabIndex = 4;
            this.btnDeleteLek.Text = "Brisanje";
            this.btnDeleteLek.UseVisualStyleBackColor = false;
            this.btnDeleteLek.Click += new System.EventHandler(this.btnDeleteLek_Click);
            // 
            // btnChangeLek
            // 
            this.btnChangeLek.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChangeLek.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLek.Location = new System.Drawing.Point(33, 186);
            this.btnChangeLek.Name = "btnChangeLek";
            this.btnChangeLek.Size = new System.Drawing.Size(196, 47);
            this.btnChangeLek.TabIndex = 3;
            this.btnChangeLek.Text = "Izmena";
            this.btnChangeLek.UseVisualStyleBackColor = false;
            this.btnChangeLek.Click += new System.EventHandler(this.btnChangeLek_Click);
            // 
            // btnAddLek
            // 
            this.btnAddLek.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddLek.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLek.Location = new System.Drawing.Point(33, 80);
            this.btnAddLek.Name = "btnAddLek";
            this.btnAddLek.Size = new System.Drawing.Size(196, 47);
            this.btnAddLek.TabIndex = 2;
            this.btnAddLek.Text = "Unos";
            this.btnAddLek.UseVisualStyleBackColor = false;
            this.btnAddLek.Click += new System.EventHandler(this.btnAddLek_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.btnDeleteProizvodjac);
            this.panel3.Controls.Add(this.btnSearchProizvodjac);
            this.panel3.Controls.Add(this.btnAddProizvodjac);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(534, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 425);
            this.panel3.TabIndex = 2;
            // 
            // btnDeleteProizvodjac
            // 
            this.btnDeleteProizvodjac.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteProizvodjac.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProizvodjac.Location = new System.Drawing.Point(29, 292);
            this.btnDeleteProizvodjac.Name = "btnDeleteProizvodjac";
            this.btnDeleteProizvodjac.Size = new System.Drawing.Size(196, 47);
            this.btnDeleteProizvodjac.TabIndex = 8;
            this.btnDeleteProizvodjac.Text = "Brisanje";
            this.btnDeleteProizvodjac.UseVisualStyleBackColor = false;
            this.btnDeleteProizvodjac.Click += new System.EventHandler(this.btnDeleteProizvodjac_Click);
            // 
            // btnSearchProizvodjac
            // 
            this.btnSearchProizvodjac.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearchProizvodjac.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProizvodjac.Location = new System.Drawing.Point(29, 186);
            this.btnSearchProizvodjac.Name = "btnSearchProizvodjac";
            this.btnSearchProizvodjac.Size = new System.Drawing.Size(196, 47);
            this.btnSearchProizvodjac.TabIndex = 7;
            this.btnSearchProizvodjac.Text = "Pretraga";
            this.btnSearchProizvodjac.UseVisualStyleBackColor = false;
            this.btnSearchProizvodjac.Click += new System.EventHandler(this.btnSearchProizvodjac_Click);
            // 
            // btnAddProizvodjac
            // 
            this.btnAddProizvodjac.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddProizvodjac.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProizvodjac.Location = new System.Drawing.Point(29, 80);
            this.btnAddProizvodjac.Name = "btnAddProizvodjac";
            this.btnAddProizvodjac.Size = new System.Drawing.Size(196, 47);
            this.btnAddProizvodjac.TabIndex = 6;
            this.btnAddProizvodjac.Text = "Unos";
            this.btnAddProizvodjac.UseVisualStyleBackColor = false;
            this.btnAddProizvodjac.Click += new System.EventHandler(this.btnAddProizvodjac_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proizvodjaci lekova";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prijavljeni korisnik:";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnik.Location = new System.Drawing.Point(173, 13);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(56, 27);
            this.lblKorisnik.TabIndex = 4;
            this.lblKorisnik.Text = "label5";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(676, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Odjava";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavna forma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteGrupa;
        private System.Windows.Forms.Button btnSearchGrupa;
        private System.Windows.Forms.Button btnAddGrupa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteLek;
        private System.Windows.Forms.Button btnChangeLek;
        private System.Windows.Forms.Button btnAddLek;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteProizvodjac;
        private System.Windows.Forms.Button btnSearchProizvodjac;
        private System.Windows.Forms.Button btnAddProizvodjac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Button btnLogout;
    }
}