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
    public partial class OdemeForm : Form
    {
        private readonly Sefer _sefer;
        private readonly int _koltukNo;
        private decimal _toplamFiyat;
        public OdemeForm(Sefer sefer, int koltukNo)
        {
            _sefer = sefer;
            _koltukNo = koltukNo;
            InitializeComponent();
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {
            var user = Program.AktifYolcu;

            lblAdSoyadDeger.Text = user.TamAd;
            lblTCDeger.Text = user.TC;
            lblTelefonDeger.Text = user.Telefon;
            lblEmailDeger.Text = user.Email;
            lblOzetFiyat.Text = $"{_toplamFiyat:N0} TL";

            FiyatGuncelle();
        }

        private void FiyatGuncelle()
        {
            string tur = cmbBiletTuru.SelectedItem?.ToString() ?? "Tam";
            decimal carpan = 1;
            if(tur == "Ogrenci (%50)")
            {
                carpan = 0.5m;
            } else if(tur == "65+ (%75)")
            {
                carpan = 0.75m;
            } else
            {
                carpan = 0;
            }
            _toplamFiyat = Math.Round(_sefer.Fiyat * carpan, 2);

            lblOzetSefer.Text = $"{_sefer.Kalkis}  →  {_sefer.Varis}";
            lblOzetTarih.Text = $"{_sefer.SeferTarihi:dd.MM.yyyy}   {_sefer.KalkisSaati}";
            lblOzetKoltuk.Text = $"Koltuk No: {_koltukNo}";
            lblOzetTur.Text = $"Bilet Türü: {tur}";
            lblOzetFiyat.Text = $"{_toplamFiyat:N0} TL";
        }

        private void cmbBiletTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiyatGuncelle();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            try
            {
                string biletTuru = cmbBiletTuru.SelectedItem?.ToString() ?? "Tam";

                string biletNo = DatabaseHelper.BiletOlustur(
                    _sefer.SeferID,
                    Program.AktifYolcu.YolcuID,
                    _koltukNo,
                    biletTuru,
                    _toplamFiyat,
                    "Online"
                );

                MessageBox.Show(
                    $"Biletiniz başarıyla alındı!\n\n" +
                    $"Bilet No   :  {biletNo}\n" +
                    $"Güzergah  :  {_sefer.Kalkis}  →  {_sefer.Varis}\n" +
                    $"Tarih       :  {_sefer.SeferTarihi:dd.MM.yyyy}  {_sefer.KalkisSaati}\n" +
                    $"Koltuk     :  {_koltukNo}\n" +
                    $"Ücret       :  {_toplamFiyat:N0} ₺",
                    "Bilet Alındı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilet oluşturulurken hata: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
