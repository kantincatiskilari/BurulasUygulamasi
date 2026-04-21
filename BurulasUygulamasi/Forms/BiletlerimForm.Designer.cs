namespace BurulasUygulamasi.Forms
{
    partial class BiletlerimForm
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblYolcu = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.dgvBiletler = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.colBiletID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBiletNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKalkis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKoltuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIptal = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiletler)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlHeader.Controls.Add(this.lblSonuc);
            this.pnlHeader.Controls.Add(this.lblYolcu);
            this.pnlHeader.Controls.Add(this.lblH);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(884, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
            this.lblSonuc.Location = new System.Drawing.Point(20, 82);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 15);
            this.lblSonuc.TabIndex = 2;
            // 
            // lblYolcu
            // 
            this.lblYolcu.AutoSize = true;
            this.lblYolcu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.lblYolcu.Location = new System.Drawing.Point(22, 44);
            this.lblYolcu.Name = "lblYolcu";
            this.lblYolcu.Size = new System.Drawing.Size(0, 15);
            this.lblYolcu.TabIndex = 1;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblH.ForeColor = System.Drawing.Color.White;
            this.lblH.Location = new System.Drawing.Point(20, 12);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(96, 25);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "Biletlerim";
            // 
            // dgvBiletler
            // 
            this.dgvBiletler.AllowUserToAddRows = false;
            this.dgvBiletler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBiletler.BackgroundColor = System.Drawing.Color.White;
            this.dgvBiletler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBiletler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiletler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBiletID,
            this.colBiletNo,
            this.colKalkis,
            this.colVaris,
            this.colTarih,
            this.colSaat,
            this.colKoltuk,
            this.colFiyat,
            this.colDurum,
            this.colIptal});
            this.dgvBiletler.Location = new System.Drawing.Point(23, 82);
            this.dgvBiletler.Name = "dgvBiletler";
            this.dgvBiletler.RowHeadersVisible = false;
            this.dgvBiletler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBiletler.Size = new System.Drawing.Size(843, 335);
            this.dgvBiletler.TabIndex = 3;
            this.dgvBiletler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBiletler_CellClick);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(725, 430);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 36);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // colBiletID
            // 
            this.colBiletID.HeaderText = "Column1";
            this.colBiletID.Name = "colBiletID";
            this.colBiletID.Visible = false;
            // 
            // colBiletNo
            // 
            this.colBiletNo.FillWeight = 14F;
            this.colBiletNo.HeaderText = "Bilet No";
            this.colBiletNo.Name = "colBiletNo";
            this.colBiletNo.ReadOnly = true;
            // 
            // colKalkis
            // 
            this.colKalkis.FillWeight = 18F;
            this.colKalkis.HeaderText = "Kalkış";
            this.colKalkis.Name = "colKalkis";
            this.colKalkis.ReadOnly = true;
            // 
            // colVaris
            // 
            this.colVaris.FillWeight = 18F;
            this.colVaris.HeaderText = "Varış";
            this.colVaris.Name = "colVaris";
            this.colVaris.ReadOnly = true;
            // 
            // colTarih
            // 
            this.colTarih.FillWeight = 10F;
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            // 
            // colSaat
            // 
            this.colSaat.FillWeight = 8F;
            this.colSaat.HeaderText = "Saat";
            this.colSaat.Name = "colSaat";
            this.colSaat.ReadOnly = true;
            // 
            // colKoltuk
            // 
            this.colKoltuk.FillWeight = 8F;
            this.colKoltuk.HeaderText = "Koltuk";
            this.colKoltuk.Name = "colKoltuk";
            this.colKoltuk.ReadOnly = true;
            // 
            // colFiyat
            // 
            this.colFiyat.FillWeight = 10F;
            this.colFiyat.HeaderText = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.ReadOnly = true;
            // 
            // colDurum
            // 
            this.colDurum.FillWeight = 8F;
            this.colDurum.HeaderText = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.ReadOnly = true;
            // 
            // colIptal
            // 
            this.colIptal.FillWeight = 6F;
            this.colIptal.HeaderText = "";
            this.colIptal.Name = "colIptal";
            this.colIptal.ReadOnly = true;
            this.colIptal.Text = "İptal Et";
            // 
            // BiletlerimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dgvBiletler);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 517);
            this.Name = "BiletlerimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Biletlerim";
            this.Load += new System.EventHandler(this.BiletlerimForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiletler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblYolcu;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.DataGridView dgvBiletler;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBiletID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBiletNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKalkis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaris;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKoltuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.DataGridViewButtonColumn colIptal;
    }
}