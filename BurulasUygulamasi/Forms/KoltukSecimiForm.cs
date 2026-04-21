using BurulasUygulamasi.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurulasUygulamasi.Forms
{
    public partial class KoltukSecimiForm : Form
    {
        private readonly Sefer _sefer;
        private List<int> _doluKoltuklar;
        private int _seciliKoltuk = 0;

        // Kullanılacak Renkler
        private static readonly Color RenkBos = Color.FromArgb(220, 235, 255);
        private static readonly Color RenkDolu = Color.FromArgb(220, 60, 60);
        private static readonly Color RenkSecili = Color.FromArgb(30, 160, 80);
        private static readonly Color RenkKoridorBg = Color.FromArgb(240, 242, 245);

        public KoltukSecimiForm(Sefer sefer)
        {
            InitializeComponent();
            _sefer = sefer;
        }

        private void KoltukPlaniniCiz()
        {
            pnlKoltuklar.Controls.Clear();

            int satir = (int)Math.Ceiling(_sefer.KoltukSayisi / 4.0);
            int btnW = 52, btnH = 44, marginX = 8, marginY = 8;

            // Sol taraf: A-B, Sağ taraf: C-D, ortada koridor
            for (int s = 0; s < satir; s++)
            {
                // Sıra numarası
                var lblSira = new Label
                {
                    Text = (s + 1).ToString(),
                    Size = new Size(22, btnH),
                    Location = new Point(0, s * (btnH + marginY) + 10),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8f),
                    ForeColor = Color.Gray
                };
                pnlKoltuklar.Controls.Add(lblSira);

                // A - B - [koridor] - C - D
                int[] kolSiraA = { 0, 1 };    // sol A,B
                int[] kolSiraB = { 2, 3 };    // sag C,D

                for (int k = 0; k < 4; k++)
                {
                    int koltukNo = s * 4 + k + 1;
                    if (koltukNo > _sefer.KoltukSayisi) break;

                    // Koridor boşluğu
                    int xOffset = k < 2
                        ? 28 + k * (btnW + marginX)
                        : 28 + k * (btnW + marginX) + 30;  // +30 koridor

                    var btn = new Button
                    {
                        Size = new Size(btnW, btnH),
                        Location = new Point(xOffset, s * (btnH + marginY) + 10),
                        Text = koltukNo.ToString(),
                        Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                        FlatStyle = FlatStyle.Flat,
                        Tag = koltukNo,
                        Cursor = Cursors.Hand
                    };
                    btn.FlatAppearance.BorderSize = 0;

                    if (_doluKoltuklar.Contains(koltukNo))
                    {
                        btn.BackColor = RenkDolu;
                        btn.ForeColor = Color.White;
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.BackColor = RenkBos;
                        btn.ForeColor = Color.FromArgb(30, 85, 160);
                        btn.Click += KoltukSecildi;
                    }

                    pnlKoltuklar.Controls.Add(btn);
                }
            }

            pnlKoltuklar.AutoScrollMinSize = new Size(310, satir * (btnH + marginY) + 20);
        }

        private void KoltukSecildi(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if(_seciliKoltuk > 0)
            {
                foreach (Control c in pnlKoltuklar.Controls)
                {
                    if(c is Button b && b.Enabled && (int)b.Tag == _seciliKoltuk)
                    {
                        b.BackColor = RenkBos;
                        b.ForeColor = Color.FromArgb(30,85,160);
                    }
                }
            }

            _seciliKoltuk = (int)btn.Tag;
            btn.BackColor = RenkSecili;
            btn.ForeColor = Color.White;

            btnDevam.Enabled = true;
        }

        private void KoltukSecimiForm_Load(object sender, EventArgs e)
        {
            lblSeferInfo.Text = $"{_sefer.Kalkis} -> {_sefer.Varis}  |  " +
                $"{_sefer.SeferTarihi:dd.MM.yyyy} {_sefer.KalkisSaati}  |  " +
                $"{_sefer.Fiyat:N0} TL";

            try
            {
                _doluKoltuklar = DatabaseHelper.GetDoluKoltuklar(_sefer.SeferID);
            }
            catch (Exception ex)
            {
                _doluKoltuklar = new List<int>();
            }
            KoltukPlaniniCiz();
            btnDevam.Enabled = false;
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if(_seciliKoltuk == 0)
            {
                return;
            }

            var odemeForm = new OdemeForm(_sefer, _seciliKoltuk);
            odemeForm.ShowDialog();
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
