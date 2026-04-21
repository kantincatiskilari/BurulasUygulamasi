namespace BurulasUygulamasi.Forms
{
    partial class SeferAramaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.dgvSeferler = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKalkis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKoltuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlHeader.Controls.Add(this.lblTarih);
            this.pnlHeader.Controls.Add(this.lblRoute);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(885, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.lblTarih.Location = new System.Drawing.Point(22, 46);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 17);
            this.lblTarih.TabIndex = 1;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoute.ForeColor = System.Drawing.Color.White;
            this.lblRoute.Location = new System.Drawing.Point(20, 12);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(0, 25);
            this.lblRoute.TabIndex = 0;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSonuc.Location = new System.Drawing.Point(17, 94);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(84, 17);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "Yükleniyor...";
            // 
            // dgvSeferler
            // 
            this.dgvSeferler.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvSeferler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSeferler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeferler.BackgroundColor = System.Drawing.Color.White;
            this.dgvSeferler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeferler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colKalkis,
            this.colVaris,
            this.colKoltuk,
            this.colFiyat,
            this.colSec});
            this.dgvSeferler.EnableHeadersVisualStyles = false;
            this.dgvSeferler.Location = new System.Drawing.Point(20, 125);
            this.dgvSeferler.Name = "dgvSeferler";
            this.dgvSeferler.RowHeadersVisible = false;
            this.dgvSeferler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeferler.Size = new System.Drawing.Size(831, 340);
            this.dgvSeferler.TabIndex = 3;
            this.dgvSeferler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeferler_CellClick);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(731, 501);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 36);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Geri Dön";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // colID
            // 
            this.colID.FillWeight = 15F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // colKalkis
            // 
            this.colKalkis.FillWeight = 15F;
            this.colKalkis.HeaderText = "Kalkış";
            this.colKalkis.Name = "colKalkis";
            this.colKalkis.ReadOnly = true;
            // 
            // colVaris
            // 
            this.colVaris.FillWeight = 15F;
            this.colVaris.HeaderText = "Varış";
            this.colVaris.Name = "colVaris";
            this.colVaris.ReadOnly = true;
            // 
            // colKoltuk
            // 
            this.colKoltuk.FillWeight = 20F;
            this.colKoltuk.HeaderText = "Boş / Toplam";
            this.colKoltuk.Name = "colKoltuk";
            this.colKoltuk.ReadOnly = true;
            // 
            // colFiyat
            // 
            this.colFiyat.FillWeight = 20F;
            this.colFiyat.HeaderText = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.ReadOnly = true;
            // 
            // colSec
            // 
            this.colSec.FillWeight = 15F;
            this.colSec.HeaderText = "Seç";
            this.colSec.Name = "colSec";
            this.colSec.ReadOnly = true;
            this.colSec.Text = "Seç";
            // 
            // SeferAramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(885, 587);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dgvSeferler);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SeferAramaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seferler";
            this.Load += new System.EventHandler(this.SeferAramaForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.DataGridView dgvSeferler;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKalkis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaris;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKoltuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFiyat;
        private System.Windows.Forms.DataGridViewButtonColumn colSec;
    }
}