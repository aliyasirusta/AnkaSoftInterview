using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorevYonetimSistemi
{

    public partial class Form2 : Form
    {
        private VeritabaniIslemleri dbIslemleri = new VeritabaniIslemleri();
        public Form2()
        {
            InitializeComponent();
        }


        private void cmbKullaniciTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {                               //KAYIT İŞLEMİNİ YAPAR GEREKLİ VERİLERİ VERİTABANIBA KAYDEDER 
            string kullaniciAdi = txtKayitKullaniciAdi.Text;
            string sifre = txtKayitSifre.Text;
            string sifreTekrar = txtKayitSifreTekrar.Text;
            
             string kullaniciTipi = cmbKullaniciTipi.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre) || string.IsNullOrWhiteSpace(sifreTekrar) || string.IsNullOrWhiteSpace(kullaniciTipi))
            {
                lblKayitHata.Text = "Lütfen tüm alanları doldurun.";
                lblKayitHata.Visible = true;
                return;
            }

            if (sifre != sifreTekrar)
            {
                lblKayitHata.Text = "Şifreler eşleşmiyor.";
                lblKayitHata.Visible = true;
                return;
            }

            if (dbIslemleri.KullaniciAdiVarMi(kullaniciAdi))
            {
                lblKayitHata.Text = "Bu kullanıcı adı zaten kayıtlı.";
                lblKayitHata.Visible = true;
                return;
            }

            if (dbIslemleri.KullaniciKaydet(kullaniciAdi, sifre, kullaniciTipi))
            {
                MessageBox.Show("Kayıt başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            else
            {
                lblKayitHata.Text = "Kayıt sırasında bir hata oluştu.";
                lblKayitHata.Visible = true;
            }
        }

        private void btnGirisSayfasinaDon_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
