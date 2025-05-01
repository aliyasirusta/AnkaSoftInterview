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
    public partial class StandartKullaniciPaneliForm : Form
    {
        private VeritabaniIslemleri dbIslemleri = new VeritabaniIslemleri();
        private int _girisYapanKullaniciId;

        public StandartKullaniciPaneliForm(int kullaniciId)
        {
            InitializeComponent();
            _girisYapanKullaniciId = kullaniciId;
        }
        private void dgvGorevlerim_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGorevlerim.SelectedRows.Count > 0)
            {
                txtGorevIdGuncelleStandart.Text = dgvGorevlerim.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void StandartKullaniciPaneliForm_Load(object sender, EventArgs e)
        {
            GorevleriListele();
            cmbYeniDurumStandart.Items.AddRange(new string[] { "Beklemede", "Devam Ediyor", "Tamamlandı" });
            KullaniciBilgileriniGoster();
            dgvGorevlerim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void GorevleriListele() //GİRİŞ YAPILAN KULLANICIYA AİT OLAN GÖREVLERİ LİSTELER
        {
            List<Tuple<int, string, string>> gorevler = dbIslemleri.KullaniciGorevleriniGetir(_girisYapanKullaniciId);
            dgvGorevlerim.DataSource = gorevler;
            dgvGorevlerim.Columns[0].HeaderText = "ID";
            dgvGorevlerim.Columns[1].HeaderText = "Açıklama";
            dgvGorevlerim.Columns[2].HeaderText = "Durum";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 girisForm = new Form1();
            girisForm.Show();
            this.Close();

        }
        private void btnGorevDurumGuncelleStandart_Click(object sender, EventArgs e)
        {                                   //GÖREV DURUMU GÜNCELLEMESİ İŞLEMİNİ YAPAR
            if (string.IsNullOrWhiteSpace(txtGorevIdGuncelleStandart.Text))
            {
                MessageBox.Show("Lütfen listeden bir görev seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbYeniDurumStandart.SelectedItem == null)
            {
                MessageBox.Show("Lütfen yeni bir durum seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int gorevId = int.Parse(txtGorevIdGuncelleStandart.Text);
            string yeniDurum = cmbYeniDurumStandart.SelectedItem.ToString();

            if (dbIslemleri.GorevDurumuGuncelle(gorevId, yeniDurum))
            {
                MessageBox.Show("Görev durumu güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GorevleriListele();
            }
            else
            {
                MessageBox.Show("Görev durumu güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            KullaniciBilgileriniGoster();
            txtGorevIdGuncelleStandart.Clear();
            cmbYeniDurumStandart.SelectedIndex = -1;
        }
        private void KullaniciBilgileriniGoster()
        {                                           //GİRİŞ YAPILAN KULLANICIYA GÖRE VERİTABANINDAN O KULLANICININ BİLGİLERİNİ ÇEKER
            Tuple<string, string> kullaniciBilgileri = dbIslemleri.KullaniciBilgileriniGetir(_girisYapanKullaniciId);
            if (kullaniciBilgileri != null)
            {
                lblKullaniciAdi.Text = "Kullanıcı Adı: " + kullaniciBilgileri.Item1;
                lblKullaniciTipi.Text = "Kullanıcı Tipi: " + kullaniciBilgileri.Item2;

                int tamamlanmamisSayisi = dbIslemleri.TamamlanmamisGorevSayisiGetir(_girisYapanKullaniciId);
                lblNameTamamlanmamisSayi.Text = tamamlanmamisSayisi.ToString();
            }
        }
    }


}
