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
    public partial class BiletlerimForm : Form
    {
        private List<Bilet> _biletler;
        public BiletlerimForm()
        {
            InitializeComponent();
        }

        private void BiletlerimForm_Load(object sender, EventArgs e)
        {
            if(Program.AktifYolcu == null)
            {
                this.Close();
                return;
            }
            lblYolcu.Text = $"{Program.AktifYolcu.TamAd}";
            BiletleriYukle();
        }
        private void BiletleriYukle()
        {
            _biletler = DatabaseHelper.GetYolcuBiletleri(Program.AktifYolcu.YolcuID);
            dgvBiletler.Rows.Clear();
            foreach (var item in _biletler)
            {
                dgvBiletler.Rows.Add(
                    item.BiletID,
                    item.BiletNo,
                    item.Kalkis,
                    item.Varis,
                    item.SeferTarihi.ToString("dd.MM.yyyy"),
                    item.KalkisSaati,
                    item.KoltukNo,
                    $"{item.Fiyat:N0} TL",
                    item.Durum,
                    item.Durum == "Aktif" ? "İptal Et" : "-"
                 );
                int sonSatir = dgvBiletler.Rows.Count - 1;
                dgvBiletler.Rows[sonSatir].DefaultCellStyle.ForeColor = item.Durum == "İptal" ? Color.Gray : Color.Black;
            }
            lblSonuc.Text = $"{_biletler.Count} bilet";
        }

        private void dgvBiletler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex != dgvBiletler.Columns["colIptal"].Index)
            {
                return;
            }
            Bilet bilet = _biletler[e.RowIndex];
            if(bilet.Durum != "Aktif")
            {
                return;
            }
            var iptalDialog = MessageBox.Show(
                $"Bilet no: {bilet.BiletNo}\n {bilet.Kalkis} -> {bilet.Varis} \n\n Bu bileti iptal etmek istediğinizden emin misiniz?",
                "Bilet İptali",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (iptalDialog == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.BiletIptal(bilet.BiletID);
                    MessageBox.Show("Bilet iptal edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BiletleriYukle();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("İptal sırasında hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
