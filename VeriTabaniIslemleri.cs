using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

public class VeritabaniIslemleri
{                                                   //VERİTABANI BAĞLANTISI YAPILDI
    private string baglantiDizesi = "Server=DESKTOP-5VHFHL5;Database=GorevYonetimDB;Integrated Security=True;";

    public VeritabaniIslemleri()
    {   
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                Console.WriteLine("Veritabanı bağlantısı başarılı.");
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Veritabanı bağlantı hatası: " + ex.Message);
  
        }
    }

    private string SifreHashle(string sifre) //GİRİLEN ŞİFREYİ SHA256 ALGORİTMASI İLE ŞİFRELER.
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifre));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }

    public bool KullaniciKaydet(string kullaniciAdi, string sifre, string kullaniciTipi)
    {                                                               //YENİ BİR KULLANICI VERİTABANINA KAYDEDER.
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, KullaniciTipi) VALUES (@kullaniciAdi, @sifre, @kullaniciTipi)";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", SifreHashle(sifre));
                    komut.Parameters.AddWithValue("@kullaniciTipi", kullaniciTipi);
                    return komut.ExecuteNonQuery() > 0;
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Kayıt hatası: " + ex.Message);
            return false;
        }
    }

    public Tuple<int, string> KullaniciDogrula(string kullaniciAdi, string sifre)
    {                                           //GİRİLEN KULLANICI ADI VE ŞİFREYİ VERİTABNINDA KONTROL EDER.
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                string sorgu = "SELECT KullaniciId, KullaniciTipi FROM Kullanicilar WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", SifreHashle(sifre));
                    using (SqlDataReader okuyucu = komut.ExecuteReader())
                    {
                        if (okuyucu.Read())
                        {
                            int kullaniciId = okuyucu.GetInt32(0);
                            string kullaniciTipi = okuyucu.GetString(1); 
                            return Tuple.Create(kullaniciId, kullaniciTipi);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Giriş hatası: " + ex.Message);
            return null;
        }
    }

    public bool KullaniciAdiVarMi(string kullaniciAdi)
    {                           //VERİLEN KULLANICI ADININ VERİTABANINDA OLUP OLMADIĞINI KONTROL EDER
        using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
        {
            baglanti.Open();
            string sorgu = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @kullaniciAdi";
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                return (int)komut.ExecuteScalar() > 0;
            }
        }
    }

    public List<Tuple<int, string, string>> TumKullanicilariGetir()
    {                                                   //VERİTABANINDA TÜM KULLANICILARIN VERİSİNİ LİSTE OLARAK GETİRİR
        List<Tuple<int, string, string>> kullanicilar = new List<Tuple<int, string, string>>();
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                string sorgu = "SELECT KullaniciId, KullaniciAdi, KullaniciTipi FROM Kullanicilar";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                using (SqlDataReader okuyucu = komut.ExecuteReader())
                {
                    while (okuyucu.Read())
                    {
                        kullanicilar.Add(Tuple.Create(okuyucu.GetInt32(0), okuyucu.GetString(1), okuyucu.GetString(2)));
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Kullanıcıları getirme hatası: " + ex.Message);         
        }
        return kullanicilar;
    }
    public List<Tuple<int, string, string>> KullaniciGorevleriniGetir(int kullaniciId)
    {                                                   //BELİRLİ BİR KULLANICININ VERİLERİNİ GETİRİR.
        List<Tuple<int, string, string>> gorevler = new List<Tuple<int, string, string>>();
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                string sorgu = "SELECT GorevId, Aciklama, Durum FROM Gorevler WHERE AtananKullaniciId = @kullaniciId";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    using (SqlDataReader okuyucu = komut.ExecuteReader())
                    {
                        while (okuyucu.Read())
                        {
                            gorevler.Add(Tuple.Create(okuyucu.GetInt32(0),
                            okuyucu.IsDBNull(1) ? "" : okuyucu.GetString(1), 
                            okuyucu.IsDBNull(2) ? "" : okuyucu.GetString(2))); 
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Kullanıcı görevlerini getirme hatası: " + ex.Message);
            
        }
        return gorevler;
    }
    public bool YeniGorevEkle(string aciklama, int atananKullaniciId)
    {                                   //YENİ BİR GÖREVİ VERİTABANINA EKLER VE BAŞLANGIÇ DURUMUNU BEKLEMEDE OLARAK AYARLAR
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Gorevler (Aciklama, AtananKullaniciId, Durum) VALUES (@aciklama, @atananKullaniciId, 'Beklemede')";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@aciklama", aciklama);
                    komut.Parameters.AddWithValue("@atananKullaniciId", atananKullaniciId);
                    return komut.ExecuteNonQuery() > 0;
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Yeni görev ekleme hatası: " + ex.Message);
            return false;
        }

    }
    public List<Tuple<int, string, string, string>> TumGorevleriGetir()
    {                                               //BÜTÜN GÖREVLERİ LİSTE ŞEKLİNDE GETİRİR
        List<Tuple<int, string, string, string>> gorevler = new List<Tuple<int, string, string, string>>();
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                string sorgu = @"
                SELECT G.GorevId, G.Aciklama, G.Durum, K.KullaniciAdi
                FROM Gorevler G
                INNER JOIN Kullanicilar K ON G.AtananKullaniciId = K.KullaniciId;";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                using (SqlDataReader okuyucu = komut.ExecuteReader())
                {
                    while (okuyucu.Read())
                    {
                        gorevler.Add(Tuple.Create(okuyucu.GetInt32(0),
                            okuyucu.IsDBNull(1) ? "" :   okuyucu.GetString(1),
                            okuyucu.IsDBNull(2) ? "" : okuyucu.GetString(2),
                            okuyucu.IsDBNull(3) ? "" :  okuyucu.GetString(3)));
                    }
                }
            }
        }

        catch (SqlException ex)
        {
            Console.WriteLine("Tüm görevleri getirme hatası: " + ex.Message);
        }
        return gorevler;
    }
    public bool GorevDurumuGuncelle(int gorevId, string yeniDurum)
    {                                   //BELİRLİ BİR GÖREVİN DURUMUNU GÜNCELLER
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                string sorgu = "UPDATE Gorevler SET Durum = @yeniDurum WHERE GorevId = @gorevId";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@gorevId", gorevId);
                    komut.Parameters.AddWithValue("@yeniDurum", yeniDurum);
                    return komut.ExecuteNonQuery() > 0;
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Görev durumu güncelleme hatası: " + ex.Message);
            return false;
        }
    }
    public Tuple<string, string> KullaniciBilgileriniGetir(int kullaniciId)
    {                                           //BELİRLİ BİR KULLANICININ VERİLERİNİ GETİRİR
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                string sorgu = "SELECT KullaniciAdi, KullaniciTipi FROM Kullanicilar WHERE KullaniciId = @kullaniciId";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    using (SqlDataReader okuyucu = komut.ExecuteReader())
                    {
                        if (okuyucu.Read())
                        {
                            string kullaniciAdi = okuyucu.GetString(0);
                            string kullaniciTipi = okuyucu.GetString(1);
                            return Tuple.Create(kullaniciAdi, kullaniciTipi);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Kullanıcı bilgilerini getirme hatası: " + ex.Message);
            return null;
        }
    }
    public int TamamlanmamisGorevSayisiGetir(int kullaniciId)
    {                                       //BELİRLİ BİR KULLANICININ TAMAMLANMAMIŞ GÖREVLERİNİ HESAPLAR.
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                string sorgu = "SELECT COUNT(*) FROM Gorevler WHERE AtananKullaniciId = @kullaniciId AND Durum <> 'Tamamlandı'";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    return (int)komut.ExecuteScalar();
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Tamamlanmamış görev sayısı getirme hatası: " + ex.Message);
            return 0;
        }
    }
    public bool GorevSil(int gorevId)
    {                       //BELİRLENEN BİR GÖREVİ VERİTABANINDAN SİLER
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();
                string sorgu = "DELETE FROM Gorevler WHERE GorevId = @gorevId";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@gorevId", gorevId);
                    return komut.ExecuteNonQuery() > 0;
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Görev silme hatası: " + ex.Message);
            return false;
        }
    }
    public bool KullaniciSil(int kullaniciId)
    {                                                   //BELİRLENEN BİR KULLANICIYI VERİTABANINDAN SİLER
        try
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiDizesi))
            {
                baglanti.Open();            
                string gorevSilSorgusu = "DELETE FROM Gorevler WHERE AtananKullaniciId = @kullaniciId";
                using (SqlCommand gorevSilKomut = new SqlCommand(gorevSilSorgusu, baglanti))
                {
                    gorevSilKomut.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    gorevSilKomut.ExecuteNonQuery(); 
                }
                
                string kullaniciSilSorgusu = "DELETE FROM Kullanicilar WHERE KullaniciId = @kullaniciId";
                using (SqlCommand kullaniciSilKomut = new SqlCommand(kullaniciSilSorgusu, baglanti))
                {
                    kullaniciSilKomut.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    return kullaniciSilKomut.ExecuteNonQuery() > 0;
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Kullanıcı silme hatası: " + ex.Message);
            return false;
        }
    }
}



