namespace BurulasUygulamasi.Forms
{
    partial class AnaForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblAltBaslik = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlArama = new System.Windows.Forms.Panel();
            this.btnSeferAra = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.lblVaris = new System.Windows.Forms.Label();
            this.cmbKalkis = new System.Windows.Forms.ComboBox();
            this.lblKalkis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBiletlerim = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlHeader.Controls.Add(this.btnBiletlerim);
            this.pnlHeader.Controls.Add(this.btnGiris);
            this.pnlHeader.Controls.Add(this.lblKullanici);
            this.pnlHeader.Controls.Add(this.lblAltBaslik);
            this.pnlHeader.Controls.Add(this.lblBaslik);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(684, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Orange;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(562, 27);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(110, 30);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.White;
            this.lblKullanici.Location = new System.Drawing.Point(444, 36);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(85, 15);
            this.lblKullanici.TabIndex = 2;
            this.lblKullanici.Text = "Giriş yapılmadı";
            // 
            // lblAltBaslik
            // 
            this.lblAltBaslik.AutoSize = true;
            this.lblAltBaslik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAltBaslik.ForeColor = System.Drawing.Color.White;
            this.lblAltBaslik.Location = new System.Drawing.Point(32, 60);
            this.lblAltBaslik.Name = "lblAltBaslik";
            this.lblAltBaslik.Size = new System.Drawing.Size(284, 17);
            this.lblAltBaslik.TabIndex = 1;
            this.lblAltBaslik.Text = "Bursa - Sabiha Gökçen Havalimanı Otobüs Bileti";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(30, 16);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(111, 40);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "BBBUS";
            // 
            // pnlArama
            // 
            this.pnlArama.BackColor = System.Drawing.Color.White;
            this.pnlArama.Controls.Add(this.btnSeferAra);
            this.pnlArama.Controls.Add(this.dtpTarih);
            this.pnlArama.Controls.Add(this.lblTarih);
            this.pnlArama.Controls.Add(this.cmbVaris);
            this.pnlArama.Controls.Add(this.lblVaris);
            this.pnlArama.Controls.Add(this.cmbKalkis);
            this.pnlArama.Controls.Add(this.lblKalkis);
            this.pnlArama.Controls.Add(this.label1);
            this.pnlArama.Location = new System.Drawing.Point(37, 136);
            this.pnlArama.Name = "pnlArama";
            this.pnlArama.Size = new System.Drawing.Size(611, 223);
            this.pnlArama.TabIndex = 4;
            // 
            // btnSeferAra
            // 
            this.btnSeferAra.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSeferAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeferAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeferAra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeferAra.ForeColor = System.Drawing.Color.White;
            this.btnSeferAra.Location = new System.Drawing.Point(235, 158);
            this.btnSeferAra.Name = "btnSeferAra";
            this.btnSeferAra.Size = new System.Drawing.Size(168, 44);
            this.btnSeferAra.TabIndex = 9;
            this.btnSeferAra.Text = "SEFER ARA";
            this.btnSeferAra.UseVisualStyleBackColor = false;
            this.btnSeferAra.Click += new System.EventHandler(this.btnSeferAra_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(449, 104);
            this.dtpTarih.MinDate = new System.DateTime(2026, 4, 20, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(145, 20);
            this.dtpTarih.TabIndex = 8;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTarih.Location = new System.Drawing.Point(446, 82);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 13);
            this.lblTarih.TabIndex = 7;
            this.lblTarih.Text = "TARİH";
            // 
            // cmbVaris
            // 
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Location = new System.Drawing.Point(235, 103);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(190, 21);
            this.cmbVaris.TabIndex = 6;
            // 
            // lblVaris
            // 
            this.lblVaris.AutoSize = true;
            this.lblVaris.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVaris.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVaris.Location = new System.Drawing.Point(232, 82);
            this.lblVaris.Name = "lblVaris";
            this.lblVaris.Size = new System.Drawing.Size(48, 13);
            this.lblVaris.TabIndex = 5;
            this.lblVaris.Text = "NEREYE";
            // 
            // cmbKalkis
            // 
            this.cmbKalkis.FormattingEnabled = true;
            this.cmbKalkis.Location = new System.Drawing.Point(16, 103);
            this.cmbKalkis.Name = "cmbKalkis";
            this.cmbKalkis.Size = new System.Drawing.Size(190, 21);
            this.cmbKalkis.TabIndex = 4;
            // 
            // lblKalkis
            // 
            this.lblKalkis.AutoSize = true;
            this.lblKalkis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalkis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblKalkis.Location = new System.Drawing.Point(13, 82);
            this.lblKalkis.Name = "lblKalkis";
            this.lblKalkis.Size = new System.Drawing.Size(58, 13);
            this.lblKalkis.TabIndex = 1;
            this.lblKalkis.Text = "NEREDEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sefer Ara";
            // 
            // btnBiletlerim
            // 
            this.btnBiletlerim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.btnBiletlerim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiletlerim.FlatAppearance.BorderSize = 0;
            this.btnBiletlerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiletlerim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletlerim.ForeColor = System.Drawing.Color.White;
            this.btnBiletlerim.Location = new System.Drawing.Point(486, 60);
            this.btnBiletlerim.Name = "btnBiletlerim";
            this.btnBiletlerim.Size = new System.Drawing.Size(110, 30);
            this.btnBiletlerim.TabIndex = 5;
            this.btnBiletlerim.Text = "Biletlerim";
            this.btnBiletlerim.UseVisualStyleBackColor = false;
            this.btnBiletlerim.Visible = false;
            this.btnBiletlerim.Click += new System.EventHandler(this.btnBiletlerim_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.pnlArama);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBBUS";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlArama.ResumeLayout(false);
            this.pnlArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblAltBaslik;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Panel pnlArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.Label lblVaris;
        private System.Windows.Forms.ComboBox cmbKalkis;
        private System.Windows.Forms.Label lblKalkis;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnSeferAra;
        private System.Windows.Forms.Button btnBiletlerim;
    }
}