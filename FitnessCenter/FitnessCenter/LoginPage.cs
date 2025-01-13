using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FitnessCenter
{
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            RegisterPage rp = new RegisterPage();
            rp.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre boş mu kontrolü
            if (string.IsNullOrWhiteSpace(txtKadi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen boş alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Veritabanı bağlantısı
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Ayar))
                {
                    connection.Open();

                    // SQL sorgusu
                    string sqlQuery = "SELECT COUNT(*) FROM KullaniciKayitlari WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        // Parametreler
                        command.Parameters.AddWithValue("@KullaniciAdi", txtKadi.Text.Trim());
                        command.Parameters.AddWithValue("@Sifre", txtSifre.Text.Trim());

                        // Sonuç
                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            // Kullanıcı doğru giriş yaptıysa ve eğer mail adresi fitnesscenter230@gmail.com ise
                            if (MailGetir(txtKadi.Text) == "fitnesscenter230@gmail.com")
                            {
                                MessageBox.Show("Admin girişi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AdminPage ap = new AdminPage(txtKadi.Text.Trim());
                                ap.Show();
                                this.Hide();
                            }
                            else if (UyelikSuresiGecmisMi(txtKadi.Text))
                            {
                                MessageBox.Show("Uyelik sureniz dolmuştur. Lütfen yeni bir hesap oluşturunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Kullanıcı adı ve şifre doğru
                                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // HomePage formunu aç ve kullanıcı adını parametre olarak gönder
                                HomePage hp = new HomePage(txtKadi.Text.Trim()); // Kullanıcı adı burada gönderiliyor
                                hp.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            // Kullanıcı adı veya şifre hatalı
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            temizlik();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumu
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string MailGetir(string kadi)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Ayar))
                {
                    connection.Open();
                    string sqlQuery = "SELECT Mail FROM KullaniciKayitlari WHERE KullaniciAdi = @KullaniciAdi";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        // Parametreyi doğru şekilde ekliyoruz
                        command.Parameters.AddWithValue("@KullaniciAdi", kadi);

                        var mail = command.ExecuteScalar(); // ExecuteScalar ile mail adresini alıyoruz.

                        return mail != null ? mail.ToString() : null; // Mail adresini döndürüyoruz
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        public void temizlik()
        {
            txtKadi.Text = "";
            txtSifre.Text = "";
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPwd fpwd = new ForgotPwd();
            fpwd.Show();
            this.Hide();
        }

        private void UyelikDurumunuGuncelle()
        {
            // Veritabanı bağlantı dizesi
            string connectionString = Properties.Settings.Default.Ayar;

            // SQL sorgusu: BitisTarihi geçmiş olan üyeliklerin durumunu 0 yap
            string query = @"
            UPDATE KullaniciKayitlari
            SET UyelikDurumu = 0
            WHERE BitisTarihi < GETDATE();";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Sorguyu çalıştır
                        int affectedRows = command.ExecuteNonQuery();

                        // Loglama için isteğe bağlı: kaç satır güncellendiğini görebilirsiniz
                        Console.WriteLine($"{affectedRows} kayıt güncellendi.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını loglayabilirsiniz
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private bool UyelikSuresiGecmisMi(string kullaniciAdi)
        {
            // Veritabanı bağlantı dizesi
            string connectionString = Properties.Settings.Default.Ayar;

            // SQL sorgusu: Belirtilen kullanıcı adıyla BitisTarihi'ni kontrol et
            string query = @"
            SELECT CASE
            WHEN BitisTarihi < GETDATE() THEN 1
            ELSE 0
            END AS UyelikDurumu
            FROM KullaniciKayitlari
            WHERE KullaniciAdi = @KullaniciAdi;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Kullanıcı adını parametre olarak ekle
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                        // Sorguyu çalıştır ve sonucu al
                        int sonuc = (int)command.ExecuteScalar();

                        // Eğer sonuc 1 ise üyelik süresi geçmiş, 0 ise geçmemiştir
                        return sonuc == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda false döndür ve hatayı logla
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
        }

        public void GuncelleBitisTarihleri()
        {
            string connectionString = Properties.Settings.Default.Ayar;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sorgu = "UPDATE KullaniciKayitlari SET BitisTarihi = DATEADD(MONTH, UyelikSuresi, KayitTarihi) WHERE UyelikSuresi > 0;";

                SqlCommand komut = new SqlCommand(sorgu, connection);

                try
                {
                    connection.Open();
                    int etkilenenSatirlar = komut.ExecuteNonQuery();
                    Console.WriteLine($"{etkilenenSatirlar} satır güncellendi.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            UyelikDurumunuGuncelle();
            GuncelleBitisTarihleri();
        }
    }
}
