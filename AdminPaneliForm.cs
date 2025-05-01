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
    public partial class AdminPaneliForm : Form
    {
        private VeritabaniIslemleri dbIslemleri = new VeritabaniIslemleri();
        public AdminPaneliForm(int kullaniciId)
        {
            InitializeComponent();
            _girisYapanKullaniciId = kullaniciId;
        }
        private int _girisYapanKullaniciId;
        private void dgvKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminPaneliForm_Load(object sender, EventArgs e)
        {
            KullanicilariListele(); // KULLANICILARI LİSTELER
            KullanicilariComboBoxaYukle();
            GorevleriListeleGrid(); // GÖREVLERİ LİSTELER
            cmbYeniDurumAdmin.Items.AddRange(new string[] { "Beklemede", "Devam Ediyor", "Tamamlandı" });
            if (dgvKullanicilar.Columns.Count > 0)
            {
                dgvKullanicilar.Columns[0].Width = 65; 
                dgvKullanicilar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            }


        }
        private void KullanicilariComboBoxaYukle()
        {
            List<Tuple<int, string, string>> kullanicilar = dbIslemleri.TumKullanicilariGetir();
            cmbKullaniciAta.DataSource = kullanicilar;
            cmbKullaniciAta.DisplayMember = "Item2"; // KULLANICI ADINI GÖSTERİR
            cmbKullaniciAta.ValueMember = "Item1";   // KULLANICI ID SİNİ DEĞER OLARAK ATAR
        }
        private void KullanicilariListele() //KULLANICILARI LİSTELEME METODU
        {
            List<Tuple<int, string, string>> kullanicilar = dbIslemleri.TumKullanicilariGetir();
            dgvKullanicilar.DataSource = kullanicilar;
            dgvKullanicilar.Columns[0].HeaderText = "ID";
            dgvKullanicilar.Columns[1].HeaderText = "Kullanıcı Adı";
            dgvKullanicilar.Columns[2].HeaderText = "Kullanıcı Tipi";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 girisForm = new Form1();
            girisForm.Show();
            this.Close(); // ADMİN FORMUNU KAPAT
        }

        private void btnGorevAta_Click(object sender, EventArgs e) // GÖREVLERİ ATAR OLUŞABİLECEK HATALAR İÇİN 
        {                                                          // EKRANA GEREKLİ MESAJLAR YANSILIR VE
                                                                   // GÖREVLER BÖLÜMÜ KULLANICILAR BÖLÜMÜ YENİLENİR.
            if (string.IsNullOrWhiteSpace(txtNameYeniGorev.Text))
            {
                MessageBox.Show("Lütfen görev açıklamasını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbKullaniciAta.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenKullaniciId = (int)cmbKullaniciAta.SelectedValue;
            string gorevAciklama = txtNameYeniGorev.Text;

            if (dbIslemleri.YeniGorevEkle(gorevAciklama, secilenKullaniciId))
            {
                GorevleriListeleGrid();
                MessageBox.Show("Görev başarıyla atandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Görev atama sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNameYeniGorev.Clear();
            cmbKullaniciAta.SelectedIndex = -1; 
        }

        private void GorevleriListeleGrid()
        {
            List<Tuple<int, string, string, string>> gorevler = dbIslemleri.TumGorevleriGetir();
            dgvGorevler.DataSource = gorevler;
            dgvGorevler.Columns[0].HeaderText = "ID";
            dgvGorevler.Columns[1].HeaderText = "Açıklama";
            dgvGorevler.Columns[2].HeaderText = "Durum";
            dgvGorevler.Columns[3].HeaderText = "Atanan Kullanıcı";
        }
                                   
        private void btnGorevDurumGuncelleAdmin_Click(object sender, EventArgs e)
        {                                       //GÖREV DURUMUNU GÜNCELLEME İŞLEMİ YAPAR VE GÖREVLERİ GÜNCELLER       
                                               
            if (string.IsNullOrWhiteSpace(txtGorevIdGuncelle.Text))
            {
                MessageBox.Show("Lütfen listeden bir görev seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbYeniDurumAdmin.SelectedItem == null)
            {
                MessageBox.Show("Lütfen yeni bir durum seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int gorevId = int.Parse(txtGorevIdGuncelle.Text);
            string yeniDurum = cmbYeniDurumAdmin.SelectedItem.ToString();

            if (dbIslemleri.GorevDurumuGuncelle(gorevId, yeniDurum))
            {
                MessageBox.Show("Görev durumu güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GorevleriListeleGrid(); 
            }
            else
            {
                MessageBox.Show("Görev durumu güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtGorevIdGuncelle.Clear();
            cmbYeniDurumAdmin.SelectedIndex = -1;
        }

        private void dgvGorevler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnGorevSil_Click(object sender, EventArgs e)
        {                                   //SEÇİLİ SATIRDAKİ GÖREVİ SİLER.

            if (dgvGorevler.SelectedRows.Count > 0)
            {
                int seciliGorevId = (int)dgvGorevler.SelectedRows[0].Cells[0].Value; 

                DialogResult result = MessageBox.Show($"Seçili görevi silmek istediğinize emin misiniz? (ID: {seciliGorevId})", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (dbIslemleri.GorevSil(seciliGorevId))
                    {
                        MessageBox.Show("Görev başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GorevleriListeleGrid(); 
                    }
                    else
                    {
                        MessageBox.Show("Görev silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için listeden bir görev seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGorevleriListele_Click_1(object sender, EventArgs e)
        {
            GorevleriListeleGrid();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {                               //SEÇİLİ SATIRDAKİ KULLANICILARI SİLER

            if (dgvKullanicilar.SelectedRows.Count > 0)
            {
                int seciliKullaniciId = (int)dgvKullanicilar.SelectedRows[0].Cells[0].Value;
                string seciliKullaniciAdi = dgvKullanicilar.SelectedRows[0].Cells[1].Value.ToString(); 

                if (_girisYapanKullaniciId == seciliKullaniciId)
                {
                    MessageBox.Show("Giriş yapan kullanıcıyı silemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"'{seciliKullaniciAdi}' adlı kullanıcıyı silmek istediğinize emin misiniz? (ID: {seciliKullaniciId})", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (dbIslemleri.KullaniciSil(seciliKullaniciId))
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KullanicilariListeleGrid(); 
                        GorevleriListeleGrid();
                        KullanicilariComboBoxaYukle(); 
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için listeden bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void KullanicilariListeleGrid()
        {
            List<Tuple<int, string, string>> kullanicilar = dbIslemleri.TumKullanicilariGetir();
            dgvKullanicilar.DataSource = kullanicilar;
            dgvKullanicilar.Columns[0].HeaderText = "ID";
            dgvKullanicilar.Columns[1].HeaderText = "Kullanıcı Adı";
            dgvKullanicilar.Columns[2].HeaderText = "Kullanıcı Tipi";

           
        }
    }

}
