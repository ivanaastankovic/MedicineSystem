namespace Client.Forms
{
    partial class FrmAddJacinaLeka
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
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvJacine = new System.Windows.Forms.DataGridView();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnDeleteJacina = new System.Windows.Forms.Button();
            this.txtOblik = new System.Windows.Forms.TextBox();
            this.cbJedinicaMere = new System.Windows.Forms.ComboBox();
            this.btnAddJacina = new System.Windows.Forms.Button();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.txtJacina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJacine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCommit);
            this.panel1.Controls.Add(this.btnDeleteJacina);
            this.panel1.Controls.Add(this.txtOblik);
            this.panel1.Controls.Add(this.cbJedinicaMere);
            this.panel1.Controls.Add(this.btnAddJacina);
            this.panel1.Controls.Add(this.txtBoja);
            this.panel1.Controls.Add(this.txtJacina);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 557);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(239, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 50);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvJacine);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 189);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jačine leka";
            // 
            // dgvJacine
            // 
            this.dgvJacine.AllowUserToAddRows = false;
            this.dgvJacine.AllowUserToDeleteRows = false;
            this.dgvJacine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJacine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvJacine.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvJacine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJacine.Location = new System.Drawing.Point(6, 24);
            this.dgvJacine.Name = "dgvJacine";
            this.dgvJacine.ReadOnly = true;
            this.dgvJacine.RowHeadersWidth = 51;
            this.dgvJacine.RowTemplate.Height = 24;
            this.dgvJacine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJacine.Size = new System.Drawing.Size(454, 150);
            this.dgvJacine.TabIndex = 15;
            // 
            // btnCommit
            // 
            this.btnCommit.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(384, 495);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(112, 50);
            this.btnCommit.TabIndex = 17;
            this.btnCommit.Text = "Potvrdi";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnDeleteJacina
            // 
            this.btnDeleteJacina.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteJacina.Location = new System.Drawing.Point(351, 235);
            this.btnDeleteJacina.Name = "btnDeleteJacina";
            this.btnDeleteJacina.Size = new System.Drawing.Size(112, 50);
            this.btnDeleteJacina.TabIndex = 16;
            this.btnDeleteJacina.Text = "Obriši";
            this.btnDeleteJacina.UseVisualStyleBackColor = true;
            this.btnDeleteJacina.Click += new System.EventHandler(this.btnDeleteJacina_Click);
            // 
            // txtOblik
            // 
            this.txtOblik.Enabled = false;
            this.txtOblik.Location = new System.Drawing.Point(218, 72);
            this.txtOblik.Name = "txtOblik";
            this.txtOblik.Size = new System.Drawing.Size(188, 22);
            this.txtOblik.TabIndex = 14;
            // 
            // cbJedinicaMere
            // 
            this.cbJedinicaMere.FormattingEnabled = true;
            this.cbJedinicaMere.Location = new System.Drawing.Point(218, 150);
            this.cbJedinicaMere.Name = "cbJedinicaMere";
            this.cbJedinicaMere.Size = new System.Drawing.Size(188, 24);
            this.cbJedinicaMere.TabIndex = 13;
            // 
            // btnAddJacina
            // 
            this.btnAddJacina.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJacina.Location = new System.Drawing.Point(218, 235);
            this.btnAddJacina.Name = "btnAddJacina";
            this.btnAddJacina.Size = new System.Drawing.Size(112, 50);
            this.btnAddJacina.TabIndex = 11;
            this.btnAddJacina.Text = "Dodaj";
            this.btnAddJacina.UseVisualStyleBackColor = true;
            this.btnAddJacina.Click += new System.EventHandler(this.btnAddJacina_Click);
            // 
            // txtBoja
            // 
            this.txtBoja.Location = new System.Drawing.Point(218, 191);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(188, 22);
            this.txtBoja.TabIndex = 10;
            // 
            // txtJacina
            // 
            this.txtJacina.Location = new System.Drawing.Point(218, 111);
            this.txtJacina.Name = "txtJacina";
            this.txtJacina.Size = new System.Drawing.Size(188, 22);
            this.txtJacina.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Boja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jačina leka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jedinica mere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oblik leka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novi oblik leka";
            // 
            // FrmAddJacinaLeka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 582);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddJacinaLeka";
            this.Text = "FrmAddJacinaLeka";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJacine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.TextBox txtJacina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddJacina;
        private System.Windows.Forms.ComboBox cbJedinicaMere;
        private System.Windows.Forms.TextBox txtOblik;
        private System.Windows.Forms.DataGridView dgvJacine;
        private System.Windows.Forms.Button btnDeleteJacina;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
    }
}