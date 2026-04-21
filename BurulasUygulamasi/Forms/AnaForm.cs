using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurulasUygulamasi.Helpers;

namespace BurulasUygulamasi.Forms
{
    public partial class AnaForm : Form
    {
        private List<Durak> _duraklar;
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            if(!DatabaseHelper.TestConnection(out string hata))
            {
                MessageBox.Show($"Veritabanına bağlanılamadı.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DuraklariYukle();
            KullaniciBilgisiniGuncelle();
        }

        private void KullaniciBilgisiniGuncelle()
        {
            if(Program.AktifYolcu != null)
            {
                lblKullanici.Text = $"{Program.AktifYolcu.TamAd}";
                btnGiris.Text = "Çıkış Yap";
                btnBiletlerim.Visible = true;
                
            }
            else
            {
                lblKullanici.Text = "Giriş yapılmadı";
                btnGiris.Text = "Giriş Yap";
                btnBiletlerim.Visible=false;
            }
        }

        private void DuraklariYukle()
        {
            try
            {
                _duraklar = DatabaseHelper.GetDuraklar();
                cmbKalkis.Items.Clear();
                cmbVaris.Items.Clear();
                foreach (var item in _duraklar)
                {
                    cmbKalkis.Items.Add(item);
                    cmbVaris.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duraklar yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(Program.AktifYolcu != null)
            {
                Program.AktifYolcu = null;
                KullaniciBilgisiniGuncelle();
                return;
            }
            using (var form = new GirisForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    KullaniciBilgisiniGuncelle();
                }
            }
        }

        private void btnSeferAra_Click(object sender, EventArgs e)
        {
            if(cmbKalkis.SelectedItem == null || cmbVaris.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kalkış ve varış noktasını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var kalkis = (Durak)cmbKalkis.SelectedItem;
            var varis = (Durak)cmbVaris.SelectedItem;

            if(kalkis.DurakID == varis.DurakID)
            {
                MessageBox.Show("Kalkış ve varış noktası aynı olamaz!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using(var form = new SeferAramaForm(kalkis, varis, dtpTarih.Value))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    KullaniciBilgisiniGuncelle();
                }
            }
        }

        private void btnBiletlerim_Click(object sender, EventArgs e)
        {
            var form = new BiletlerimForm();
                form.ShowDialog();
        }
    }
}
