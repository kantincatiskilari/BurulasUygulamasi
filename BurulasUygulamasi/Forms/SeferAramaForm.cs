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
    public partial class SeferAramaForm : Form
    {
        private readonly Durak _kalkis;
        private readonly Durak _varis;
        private readonly DateTime _tarih;
        private List<Sefer> _seferler;
        public SeferAramaForm(Durak kalkis, Durak varis, DateTime tarih)
        {
            InitializeComponent();
            _kalkis = kalkis;
            _varis = varis;
            _tarih = tarih;
           
        }

        private void SeferAramaForm_Load(object sender, EventArgs e)
        {
            lblRoute.Text = $"{_kalkis.DurakAdi} -> {_varis.DurakAdi}";
            lblTarih.Text = _tarih.ToString("dd MMMM yyyy, dddd", new System.Globalization.CultureInfo("tr-TR"));
            AramalariYukle();
        }

        private void AramalariYukle()
        {
            try
            {
                _seferler = DatabaseHelper.SeferAra(_kalkis.DurakID,_varis.DurakID, _tarih);
                dgvSeferler.Rows.Clear();
                if(_seferler.Count == 0)
                {
                    lblSonuc.Text = "Bu tarihte sefer bulunamadı.";
                    lblSonuc.ForeColor = Color.OrangeRed;
                    return;
                }
                lblSonuc.Text = $"{_seferler.Count} sefer bulundu";
                lblSonuc.ForeColor = Color.FromArgb(0, 140, 110);

                foreach (var item in _seferler)
                {
                    dgvSeferler.Rows.Add(
                        item.SeferID,
                        item.KalkisSaati,
                        item.VarisSaati,
                        $"{item.BosKoltuk} / {item.KoltukSayisi}",
                        $"{item.Fiyat:N0} TL",
                        item.BosKoltuk > 0 ? "Seç" : "Dolu"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seferler yüklenirken hata: "+ex.Message,"Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSeferler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvSeferler.Columns["colSec"].Index) {
                return;
            }

            Sefer sefer = _seferler[e.RowIndex];
            if (sefer.BosKoltuk == 0) {
                MessageBox.Show("Bu sefer dolu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Program.AktifYolcu == null)
            {
                var soru = MessageBox.Show("Bilet almak için giriş yapmanız gerekiyor: \nGiriş yapmak ister misiniz?"
                    , "Giriş Gerekli", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    var girisForm = new GirisForm();
                    girisForm.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            var koltukForm = new KoltukSecimiForm(sefer);
            koltukForm.ShowDialog();
            this.Close();
        }
    }
}
