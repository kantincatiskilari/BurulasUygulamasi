namespace BurulasUygulamasi.Forms
{
    partial class OdemeForm
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

        private void AddBilgiRow(System.Windows.Forms.Panel parent, string etiket, int y,
           out System.Windows.Forms.Label lblDeger)
        {
            var lblEtiket = new System.Windows.Forms.Label();
            lblEtiket.Text = etiket;
            lblEtiket.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            lblEtiket.ForeColor = System.Drawing.Color.Gray;
            lblEtiket.AutoSize = true;
            lblEtiket.Location = new System.Drawing.Point(14, y);

            lblDeger = new System.Windows.Forms.Label();
            lblDeger.Text = "";
            lblDeger.Font = new System.Drawing.Font("Segoe UI", 10f);
            lblDeger.ForeColor = System.Drawing.Color.FromArgb(30, 50, 80);
            lblDeger.AutoSize = true;
            lblDeger.Location = new System.Drawing.Point(14, y + 16);

            parent.Controls.Add(lblEtiket);
            parent.Controls.Add(lblDeger);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblH = new System.Windows.Forms.Label();
            this.pnlYolcu = new System.Windows.Forms.Panel();
            this.cmbBiletTuru = new System.Windows.Forms.ComboBox();
            this.lblTurBaslik = new System.Windows.Forms.Label();
            this.lblTelefonDeger = new System.Windows.Forms.Label();
            this.lblTCDeger = new System.Windows.Forms.Label();
            this.lblAdSoyadDeger = new System.Windows.Forms.Label();
            this.lblEmailDeger = new System.Windows.Forms.Label();
            this.lblYolcuBaslik = new System.Windows.Forms.Label();
            this.pnlOzet = new System.Windows.Forms.Panel();
            this.lblOzetFiyat = new System.Windows.Forms.Label();
            this.lblToplamLbl = new System.Windows.Forms.Label();
            this.sep = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOzetTur = new System.Windows.Forms.Label();
            this.lblOzetKoltuk = new System.Windows.Forms.Label();
            this.lblOzetTarih = new System.Windows.Forms.Label();
            this.lblOzetSefer = new System.Windows.Forms.Label();
            this.lblOzetBaslik = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOde = new System.Windows.Forms.Button();
            this.pnlYolcu.SuspendLayout();
            this.pnlOzet.SuspendLayout();
            this.sep.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(664, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblH.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblH.ForeColor = System.Drawing.Color.White;
            this.lblH.Location = new System.Drawing.Point(20, 14);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(121, 25);
            this.lblH.TabIndex = 1;
            this.lblH.Text = "Sipariş Özeti";
            // 
            // pnlYolcu
            // 
            this.pnlYolcu.BackColor = System.Drawing.Color.White;
            this.pnlYolcu.Controls.Add(this.cmbBiletTuru);
            this.pnlYolcu.Controls.Add(this.lblTurBaslik);
            this.pnlYolcu.Controls.Add(this.lblTelefonDeger);
            this.pnlYolcu.Controls.Add(this.lblTCDeger);
            this.pnlYolcu.Controls.Add(this.lblAdSoyadDeger);
            this.pnlYolcu.Controls.Add(this.lblEmailDeger);
            this.pnlYolcu.Controls.Add(this.lblYolcuBaslik);
            this.pnlYolcu.Location = new System.Drawing.Point(20, 70);
            this.pnlYolcu.Name = "pnlYolcu";
            this.pnlYolcu.Size = new System.Drawing.Size(310, 280);
            this.pnlYolcu.TabIndex = 2;
            // 
            // cmbBiletTuru
            // 
            this.cmbBiletTuru.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBiletTuru.FormattingEnabled = true;
            this.cmbBiletTuru.Items.AddRange(new object[] {
            "Tam",
            "Ogrenci (%50)",
            "65+ (%75)"});
            this.cmbBiletTuru.Location = new System.Drawing.Point(14, 256);
            this.cmbBiletTuru.Name = "cmbBiletTuru";
            this.cmbBiletTuru.Size = new System.Drawing.Size(280, 23);
            this.cmbBiletTuru.TabIndex = 6;
            this.cmbBiletTuru.SelectedIndexChanged += new System.EventHandler(this.cmbBiletTuru_SelectedIndexChanged);
            // 
            // lblTurBaslik
            // 
            this.lblTurBaslik.AutoSize = true;
            this.lblTurBaslik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurBaslik.ForeColor = System.Drawing.Color.Gray;
            this.lblTurBaslik.Location = new System.Drawing.Point(14, 240);
            this.lblTurBaslik.Name = "lblTurBaslik";
            this.lblTurBaslik.Size = new System.Drawing.Size(61, 15);
            this.lblTurBaslik.TabIndex = 5;
            this.lblTurBaslik.Text = "Bilet Türü";
            // 
            // lblTelefonDeger
            // 
            this.lblTelefonDeger.AutoSize = true;
            this.lblTelefonDeger.Location = new System.Drawing.Point(14, 105);
            this.lblTelefonDeger.Name = "lblTelefonDeger";
            this.lblTelefonDeger.Size = new System.Drawing.Size(38, 15);
            this.lblTelefonDeger.TabIndex = 4;
            this.lblTelefonDeger.Text = "label4";
            // 
            // lblTCDeger
            // 
            this.lblTCDeger.AutoSize = true;
            this.lblTCDeger.Location = new System.Drawing.Point(14, 80);
            this.lblTCDeger.Name = "lblTCDeger";
            this.lblTCDeger.Size = new System.Drawing.Size(38, 15);
            this.lblTCDeger.TabIndex = 3;
            this.lblTCDeger.Text = "label3";
            // 
            // lblAdSoyadDeger
            // 
            this.lblAdSoyadDeger.AutoSize = true;
            this.lblAdSoyadDeger.Location = new System.Drawing.Point(14, 53);
            this.lblAdSoyadDeger.Name = "lblAdSoyadDeger";
            this.lblAdSoyadDeger.Size = new System.Drawing.Size(38, 15);
            this.lblAdSoyadDeger.TabIndex = 2;
            this.lblAdSoyadDeger.Text = "label2";
            // 
            // lblEmailDeger
            // 
            this.lblEmailDeger.AutoSize = true;
            this.lblEmailDeger.Location = new System.Drawing.Point(14, 133);
            this.lblEmailDeger.Name = "lblEmailDeger";
            this.lblEmailDeger.Size = new System.Drawing.Size(38, 15);
            this.lblEmailDeger.TabIndex = 1;
            this.lblEmailDeger.Text = "label1";
            // 
            // lblYolcuBaslik
            // 
            this.lblYolcuBaslik.AutoSize = true;
            this.lblYolcuBaslik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYolcuBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
            this.lblYolcuBaslik.Location = new System.Drawing.Point(14, 14);
            this.lblYolcuBaslik.Name = "lblYolcuBaslik";
            this.lblYolcuBaslik.Size = new System.Drawing.Size(93, 17);
            this.lblYolcuBaslik.TabIndex = 0;
            this.lblYolcuBaslik.Text = "Yolcu Bilgileri";
            // 
            // pnlOzet
            // 
            this.pnlOzet.BackColor = System.Drawing.Color.White;
            this.pnlOzet.Controls.Add(this.lblOzetFiyat);
            this.pnlOzet.Controls.Add(this.lblToplamLbl);
            this.pnlOzet.Controls.Add(this.sep);
            this.pnlOzet.Controls.Add(this.lblOzetTur);
            this.pnlOzet.Controls.Add(this.lblOzetKoltuk);
            this.pnlOzet.Controls.Add(this.lblOzetTarih);
            this.pnlOzet.Controls.Add(this.lblOzetSefer);
            this.pnlOzet.Controls.Add(this.lblOzetBaslik);
            this.pnlOzet.Location = new System.Drawing.Point(348, 70);
            this.pnlOzet.Name = "pnlOzet";
            this.pnlOzet.Size = new System.Drawing.Size(312, 280);
            this.pnlOzet.TabIndex = 7;
            // 
            // lblOzetFiyat
            // 
            this.lblOzetFiyat.AutoSize = true;
            this.lblOzetFiyat.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzetFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
            this.lblOzetFiyat.Location = new System.Drawing.Point(14, 205);
            this.lblOzetFiyat.Name = "lblOzetFiyat";
            this.lblOzetFiyat.Size = new System.Drawing.Size(89, 47);
            this.lblOzetFiyat.TabIndex = 7;
            this.lblOzetFiyat.Text = "0 TL";
            // 
            // lblToplamLbl
            // 
            this.lblToplamLbl.AutoSize = true;
            this.lblToplamLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamLbl.ForeColor = System.Drawing.Color.Gray;
            this.lblToplamLbl.Location = new System.Drawing.Point(14, 185);
            this.lblToplamLbl.Name = "lblToplamLbl";
            this.lblToplamLbl.Size = new System.Drawing.Size(47, 15);
            this.lblToplamLbl.TabIndex = 6;
            this.lblToplamLbl.Text = "Toplam";
            // 
            // sep
            // 
            this.sep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.sep.Controls.Add(this.label1);
            this.sep.Location = new System.Drawing.Point(14, 170);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(280, 1);
            this.sep.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblOzetTur
            // 
            this.lblOzetTur.AutoSize = true;
            this.lblOzetTur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzetTur.ForeColor = System.Drawing.Color.Gray;
            this.lblOzetTur.Location = new System.Drawing.Point(14, 136);
            this.lblOzetTur.MaximumSize = new System.Drawing.Size(280, 0);
            this.lblOzetTur.Name = "lblOzetTur";
            this.lblOzetTur.Size = new System.Drawing.Size(40, 15);
            this.lblOzetTur.TabIndex = 4;
            this.lblOzetTur.Text = "label1";
            // 
            // lblOzetKoltuk
            // 
            this.lblOzetKoltuk.AutoSize = true;
            this.lblOzetKoltuk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzetKoltuk.ForeColor = System.Drawing.Color.Gray;
            this.lblOzetKoltuk.Location = new System.Drawing.Point(14, 108);
            this.lblOzetKoltuk.MaximumSize = new System.Drawing.Size(280, 0);
            this.lblOzetKoltuk.Name = "lblOzetKoltuk";
            this.lblOzetKoltuk.Size = new System.Drawing.Size(40, 15);
            this.lblOzetKoltuk.TabIndex = 3;
            this.lblOzetKoltuk.Text = "label1";
            // 
            // lblOzetTarih
            // 
            this.lblOzetTarih.AutoSize = true;
            this.lblOzetTarih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzetTarih.ForeColor = System.Drawing.Color.Gray;
            this.lblOzetTarih.Location = new System.Drawing.Point(14, 80);
            this.lblOzetTarih.MaximumSize = new System.Drawing.Size(280, 0);
            this.lblOzetTarih.Name = "lblOzetTarih";
            this.lblOzetTarih.Size = new System.Drawing.Size(40, 15);
            this.lblOzetTarih.TabIndex = 2;
            this.lblOzetTarih.Text = "label1";
            // 
            // lblOzetSefer
            // 
            this.lblOzetSefer.AutoSize = true;
            this.lblOzetSefer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzetSefer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lblOzetSefer.Location = new System.Drawing.Point(14, 48);
            this.lblOzetSefer.MaximumSize = new System.Drawing.Size(280, 0);
            this.lblOzetSefer.Name = "lblOzetSefer";
            this.lblOzetSefer.Size = new System.Drawing.Size(40, 15);
            this.lblOzetSefer.TabIndex = 1;
            this.lblOzetSefer.Text = "label1";
            // 
            // lblOzetBaslik
            // 
            this.lblOzetBaslik.AutoSize = true;
            this.lblOzetBaslik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzetBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(165)))));
            this.lblOzetBaslik.Location = new System.Drawing.Point(14, 14);
            this.lblOzetBaslik.Name = "lblOzetBaslik";
            this.lblOzetBaslik.Size = new System.Drawing.Size(85, 17);
            this.lblOzetBaslik.TabIndex = 0;
            this.lblOzetBaslik.Text = "Sipariş Özeti";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(532, 356);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(120, 30);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "Vazgeç";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOde
            // 
            this.btnOde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(110)))));
            this.btnOde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOde.FlatAppearance.BorderSize = 0;
            this.btnOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOde.ForeColor = System.Drawing.Color.White;
            this.btnOde.Location = new System.Drawing.Point(362, 356);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(120, 30);
            this.btnOde.TabIndex = 9;
            this.btnOde.Text = "Satın Al";
            this.btnOde.UseVisualStyleBackColor = false;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // OdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 394);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.pnlOzet);
            this.Controls.Add(this.pnlYolcu);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(680, 420);
            this.Name = "OdemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.OdemeForm_Load);
            this.pnlYolcu.ResumeLayout(false);
            this.pnlYolcu.PerformLayout();
            this.pnlOzet.ResumeLayout(false);
            this.pnlOzet.PerformLayout();
            this.sep.ResumeLayout(false);
            this.sep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Panel pnlYolcu;
        private System.Windows.Forms.Label lblYolcuBaslik;
        private System.Windows.Forms.ComboBox cmbBiletTuru;
        private System.Windows.Forms.Label lblTurBaslik;
        private System.Windows.Forms.Label lblTelefonDeger;
        private System.Windows.Forms.Label lblTCDeger;
        private System.Windows.Forms.Label lblAdSoyadDeger;
        private System.Windows.Forms.Label lblEmailDeger;
        private System.Windows.Forms.Panel pnlOzet;
        private System.Windows.Forms.Label lblOzetSefer;
        private System.Windows.Forms.Label lblOzetBaslik;
        private System.Windows.Forms.Label lblOzetFiyat;
        private System.Windows.Forms.Label lblToplamLbl;
        private System.Windows.Forms.Panel sep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOzetTur;
        private System.Windows.Forms.Label lblOzetKoltuk;
        private System.Windows.Forms.Label lblOzetTarih;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOde;
    }
}