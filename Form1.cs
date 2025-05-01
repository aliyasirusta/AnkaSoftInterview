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
    public partial class Form1 : Form
    {
        private VeritabaniIslemleri dbIslemleri = new VeritabaniIslemleri();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {                       // KULLANICI ADI ŞİFRE KONTROLÜ YAPAR ONA GÖRE GEREKLİ FORMU AÇAR (STANDART KULLANICI YA DA ADMİN )

            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tuple<int, string> kullaniciBilgisi = dbIslemleri.KullaniciDogrula(kullaniciAdi, sifre);

            if (kullaniciBilgisi != null)
            {
                int kullaniciId = kullaniciBilgisi.Item1;
                string kullaniciTipi = kullaniciBilgisi.Item2;

                MessageBox.Show($"Giriş başarılı! Hoş geldiniz, {kullaniciAdi} ({kullaniciTipi})", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (kullaniciTipi == "Admin")
                {
                    AdminPaneliForm adminPaneli = new AdminPaneliForm(kullaniciId); 
                    adminPaneli.Show();
                    this.Hide(); 
                }
                else if (kullaniciTipi == "Standart")
                {
                    StandartKullaniciPaneliForm standartPanel = new StandartKullaniciPaneliForm(kullaniciId); 
                    this.Hide(); 
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Clear();
            }
        }

        private void llKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 kayitForm = new Form2();
            kayitForm.ShowDialog(); // KAYIT OL FORMUNU AÇAR
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
