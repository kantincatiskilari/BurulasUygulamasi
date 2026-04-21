using System.Drawing;
using System.Windows.Forms;

namespace BurulasUygulamasi.Forms
{
    partial class KoltukSecimiForm
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

        private void AddLegend(System.Windows.Forms.Panel parent, int x, Color renk, string metin)
        {
            var box = new System.Windows.Forms.Panel
            {
                Size = new System.Drawing.Size(20, 20),
                Location = new System.Drawing.Point(x, 8),
                BackColor = renk,
            };
            var lbl = new System.Windows.Forms.Label
            {
                Text = metin,
                AutoSize = true,
                Location = new System.Drawing.Point(x + 24, 10),
                Font = new System.Drawing.Font("Segoe UI", 9f)
            };
            parent.Controls.AddRange(new System.Windows.Forms.Control[] { box, lbl });
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSeferInfo = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.pnlKoltuklar = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnDevam = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblSeferInfo);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 70);
            this.panel1.TabIndex = 0;
            // 
            // lblSeferInfo
            // 
            this.lblSeferInfo.AutoSize = true;
            this.lblSeferInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.lblSeferInfo.Location = new System.Drawing.Point(22, 42);
            this.lblSeferInfo.Name = "lblSeferInfo";
            this.lblSeferInfo.Size = new System.Drawing.Size(0, 15);
            this.lblSeferInfo.TabIndex = 1;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(20, 10);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(133, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Koltuk Seçimi";
            // 
            // pnlLegend
            // 
            this.pnlLegend.BackColor = System.Drawing.Color.Transparent;
            this.pnlLegend.Location = new System.Drawing.Point(20, 85);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(640, 36);
            this.pnlLegend.TabIndex = 2;
            // 
            // pnlKoltuklar
            // 
            this.pnlKoltuklar.AutoScroll = true;
            this.pnlKoltuklar.BackColor = System.Drawing.Color.White;
            this.pnlKoltuklar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKoltuklar.Location = new System.Drawing.Point(160, 88);
            this.pnlKoltuklar.Name = "pnlKoltuklar";
            this.pnlKoltuklar.Size = new System.Drawing.Size(340, 400);
            this.pnlKoltuklar.TabIndex = 3;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnIptal.Location = new System.Drawing.Point(390, 498);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(110, 38);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnDevam
            // 
            this.btnDevam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(160)))));
            this.btnDevam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevam.FlatAppearance.BorderSize = 0;
            this.btnDevam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevam.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDevam.Location = new System.Drawing.Point(160, 498);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(110, 38);
            this.btnDevam.TabIndex = 4;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.UseVisualStyleBackColor = false;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // KoltukSecimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(664, 541);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.pnlKoltuklar);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(680, 580);
            this.Name = "KoltukSecimiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Koltuk Seçimi";
            this.Load += new System.EventHandler(this.KoltukSecimiForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSeferInfo;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel pnlLegend;
        private Panel pnlKoltuklar;
        private Button btnIptal;
        private Button btnDevam;
    }
}