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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTC.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("TC kimlik no veya şifre giriniz", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var yolcu = DatabaseHelper.GirisYap(txtTC.Text.Trim(), txtSifre.Text.Trim());
                if (yolcu == null) {
                    lblHata.Text = "TC kimlik veya şifre hatalı";
                    lblHata.Visible = true;
                    return;
                }
                Program.AktifYolcu = yolcu;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Giriş sırasında hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
