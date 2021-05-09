namespace Client.Forms
{
    partial class FrmChangeSelectedLek
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
            this.btnChangeOblik = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvJacine = new System.Windows.Forms.DataGridView();
            this.btnAddOblik = new System.Windows.Forms.Button();
            this.btnDeleteOblik = new System.Windows.Forms.Button();
            this.cbOblik = new System.Windows.Forms.ComboBox();
            this.txtTrajanjeTerapije = new System.Windows.Forms.TextBox();
            this.txtMehanizam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedLek = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJacine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnChangeOblik);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnAddOblik);
            this.panel1.Controls.Add(this.btnDeleteOblik);
            this.panel1.Controls.Add(this.cbOblik);
            this.panel1.Controls.Add(this.txtTrajanjeTerapije);
            this.panel1.Controls.Add(this.txtMehanizam);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSelectedLek);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 576);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(352, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 40);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChangeOblik
            // 
            this.btnChangeOblik.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeOblik.Location = new System.Drawing.Point(556, 367);
            this.btnChangeOblik.Name = "btnChangeOblik";
            this.btnChangeOblik.Size = new System.Drawing.Size(96, 40);
            this.btnChangeOblik.TabIndex = 14;
            this.btnChangeOblik.Text = "Izmeni oblik";
            this.btnChangeOblik.UseVisualStyleBackColor = true;
            this.btnChangeOblik.Click += new System.EventHandler(this.btnChangeOblik_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(454, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvJacine);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 206);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oblici leka";
            // 
            // dgvJacine
            // 
            this.dgvJacine.AllowUserToAddRows = false;
            this.dgvJacine.AllowUserToDeleteRows = false;
            this.dgvJacine.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvJacine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJacine.Location = new System.Drawing.Point(6, 21);
            this.dgvJacine.Name = "dgvJacine";
            this.dgvJacine.ReadOnly = true;
            this.dgvJacine.RowHeadersWidth = 51;
            this.dgvJacine.RowTemplate.Height = 24;
            this.dgvJacine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJacine.Size = new System.Drawing.Size(480, 164);
            this.dgvJacine.TabIndex = 11;
            // 
            // btnAddOblik
            // 
            this.btnAddOblik.Enabled = false;
            this.btnAddOblik.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOblik.Location = new System.Drawing.Point(448, 206);
            this.btnAddOblik.Name = "btnAddOblik";
            this.btnAddOblik.Size = new System.Drawing.Size(96, 40);
            this.btnAddOblik.TabIndex = 10;
            this.btnAddOblik.Text = "Dodaj oblik";
            this.btnAddOblik.UseVisualStyleBackColor = true;
            this.btnAddOblik.Click += new System.EventHandler(this.btnAddOblik_Click);
            // 
            // btnDeleteOblik
            // 
            this.btnDeleteOblik.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOblik.Location = new System.Drawing.Point(556, 310);
            this.btnDeleteOblik.Name = "btnDeleteOblik";
            this.btnDeleteOblik.Size = new System.Drawing.Size(96, 40);
            this.btnDeleteOblik.TabIndex = 9;
            this.btnDeleteOblik.Text = "Obriši oblik";
            this.btnDeleteOblik.UseVisualStyleBackColor = true;
            this.btnDeleteOblik.Click += new System.EventHandler(this.btnDeleteOblik_Click);
            // 
            // cbOblik
            // 
            this.cbOblik.FormattingEnabled = true;
            this.cbOblik.Location = new System.Drawing.Point(248, 210);
            this.cbOblik.Name = "cbOblik";
            this.cbOblik.Size = new System.Drawing.Size(188, 24);
            this.cbOblik.TabIndex = 8;
            this.cbOblik.SelectionChangeCommitted += new System.EventHandler(this.cbOblik_SelectionChangeCommitted);
            // 
            // txtTrajanjeTerapije
            // 
            this.txtTrajanjeTerapije.Location = new System.Drawing.Point(248, 168);
            this.txtTrajanjeTerapije.Name = "txtTrajanjeTerapije";
            this.txtTrajanjeTerapije.Size = new System.Drawing.Size(188, 22);
            this.txtTrajanjeTerapije.TabIndex = 7;
            // 
            // txtMehanizam
            // 
            this.txtMehanizam.Location = new System.Drawing.Point(248, 124);
            this.txtMehanizam.Name = "txtMehanizam";
            this.txtMehanizam.Size = new System.Drawing.Size(188, 22);
            this.txtMehanizam.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trajanje terapije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oblik leka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mehanizam dejstva";
            // 
            // lblSelectedLek
            // 
            this.lblSelectedLek.AutoSize = true;
            this.lblSelectedLek.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedLek.Location = new System.Drawing.Point(309, 45);
            this.lblSelectedLek.Name = "lblSelectedLek";
            this.lblSelectedLek.Size = new System.Drawing.Size(62, 27);
            this.lblSelectedLek.TabIndex = 0;
            this.lblSelectedLek.Text = "label1";
            // 
            // FrmChangeSelectedLek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 601);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChangeSelectedLek";
            this.Text = "FrmChangeSelectedLek";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJacine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectedLek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMehanizam;
        private System.Windows.Forms.TextBox txtTrajanjeTerapije;
        private System.Windows.Forms.DataGridView dgvJacine;
        private System.Windows.Forms.Button btnAddOblik;
        private System.Windows.Forms.Button btnDeleteOblik;
        private System.Windows.Forms.ComboBox cbOblik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChangeOblik;
        private System.Windows.Forms.Button btnBack;
    }
}