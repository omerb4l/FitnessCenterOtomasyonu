using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace FitnessCenter
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }


        Image secilenFotograf;
        bool fotografSecildiMi = false;
        string fotoYolu = string.Empty;
        private void btnFotografYukleme_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp|Tüm Dosyalar|*.*",
                Title = "Bir Resim Seçin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Seçilen fotoğrafı Image değişkenine atama
                    secilenFotograf = Image.FromFile(openFileDialog.FileName);
                    fotografSecildiMi = true;

                    // Kaydetme dizinini belirleme
                    string kaydetmeDizini = Path.Combine(Application.StartupPath, "Resources", "Fotograflar");

                    // Dizin mevcut değilse oluşturma
                    if (!Directory.Exists(kaydetmeDizini))
                    {
                        Directory.CreateDirectory(kaydetmeDizini);
                    }

                    // Resmi kaydetme yolu
                    string kaydetmeYolu = Path.Combine(kaydetmeDizini, Guid.NewGuid() + ".jpg");

                    // Resmi kaydetme işlemi
                    secilenFotograf.Save(kaydetmeYolu, System.Drawing.Imaging.ImageFormat.Jpeg);

                    // Kaydedilen yolu bir değişkende saklama (veritabanına eklenmesi için)
                    fotoYolu = kaydetmeYolu;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fotoğraf kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (!TextBoxlarBosMu() && (rbuttonErkek.Checked || rbuttonKadin.Checked) && dateDogumGunu.EditValue != null && fotografSecildiMi && (rdb1Ay.Checked || rdb3Ay.Checked || rdb6Ay.Checked || rdb12Ay.Checked))
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!MailBostaMi(txtMail.Text))
                {
                    MessageBox.Show("Bu maille kaydolan başka bir kullanıcı var. Lütfen başka bir mail deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    secenekleriTemizle();
                    return;
                }

                if (!kAdiBostaMi(txtKadi.Text))
                {
                    MessageBox.Show("Bu kullanıcı adıyla kayıtlı başka bir kullanıcı var. Lütfen başka bir kullanıcı adı deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    secenekleriTemizle();
                    return;
                }

                int uyelikSuresi = 0;

                if (rdb1Ay.Checked)
                    uyelikSuresi = 1;
                else if (rdb3Ay.Checked)
                    uyelikSuresi = 3;
                else if (rdb6Ay.Checked)
                    uyelikSuresi = 6;
                else if (rdb12Ay.Checked)
                    uyelikSuresi = 12;

                try
                {
                    int kullaniciId;

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Ayar))
                    {
                        connection.Open();

                        // Kullanıcı kaydını ekleyin.
                        string sqlQuery = "INSERT INTO KullaniciKayitlari (KullaniciAdi, Sifre, Ad, Soyad, Cinsiyet, FotoYolu, DogumTarihi, Kilo, Boy, Biceps, Omuz, Gogus, Bel, Mail, UyelikSuresi) " +
                                          "VALUES (@KullaniciAdi, @Sifre, @Ad, @Soyad, @Cinsiyet, @FotoYolu, @DogumTarihi, @Kilo, @Boy, @Biceps, @Omuz, @Gogus, @Bel, @Mail, @UyelikSuresi); " +
                                          "SELECT SCOPE_IDENTITY();";  // Kullanıcı ID'yi geri döndürüyor.
                        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                        {
                            command.Parameters.AddWithValue("@KullaniciAdi", txtKadi.Text.Trim());
                            command.Parameters.AddWithValue("@Sifre", txtSifre.Text.Trim());
                            command.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                            command.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
                            command.Parameters.AddWithValue("@Cinsiyet", rbuttonErkek.Checked ? "Erkek" : "Kadın");
                            command.Parameters.AddWithValue("@FotoYolu", fotoYolu);
                            command.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(dateDogumGunu.EditValue));
                            command.Parameters.AddWithValue("@Kilo", Convert.ToDecimal(txtKilo.Text.Trim()));
                            command.Parameters.AddWithValue("@Boy", Convert.ToDecimal(txtBoy.Text.Trim()));
                            command.Parameters.AddWithValue("@Biceps", Convert.ToDecimal(txtBiceps.Text.Trim()));
                            command.Parameters.AddWithValue("@Omuz", Convert.ToDecimal(txtOmuz.Text.Trim()));
                            command.Parameters.AddWithValue("@Gogus", Convert.ToDecimal(txtGogus.Text.Trim()));
                            command.Parameters.AddWithValue("@Bel", Convert.ToDecimal(txtBel.Text.Trim()));
                            command.Parameters.AddWithValue("@Mail", txtMail.Text.Trim());
                            command.Parameters.AddWithValue("@UyelikSuresi", uyelikSuresi);

                            kullaniciId = Convert.ToInt32(command.ExecuteScalar());  // Kullanıcı ID alınır.
                        }

                        // Olcumgecmisi tablosuna yeni giriş ekleyin.
                        string olcumQuery = "INSERT INTO Olcumgecmisi (KullaniciID, Tarih, Boy, Kilo, Omuz, Bel, Biceps, Gogus) " +
                                            "VALUES (@KullaniciID, @Tarih, @Boy, @Kilo, @Omuz, @Bel, @Biceps, @Gogus)";

                        using (SqlCommand commandOlcum = new SqlCommand(olcumQuery, connection))
                        {
                            commandOlcum.Parameters.AddWithValue("@KullaniciID", kullaniciId);
                            commandOlcum.Parameters.AddWithValue("@Tarih", DateTime.Now);
                            commandOlcum.Parameters.AddWithValue("@Boy", Convert.ToDecimal(txtBoy.Text.Trim()));
                            commandOlcum.Parameters.AddWithValue("@Kilo", Convert.ToDecimal(txtKilo.Text.Trim()));
                            commandOlcum.Parameters.AddWithValue("@Omuz", Convert.ToDecimal(txtOmuz.Text.Trim()));
                            commandOlcum.Parameters.AddWithValue("@Bel", Convert.ToDecimal(txtBel.Text.Trim()));
                            commandOlcum.Parameters.AddWithValue("@Biceps", Convert.ToDecimal(txtBiceps.Text.Trim()));
                            commandOlcum.Parameters.AddWithValue("@Gogus", Convert.ToDecimal(txtGogus.Text.Trim()));

                            int olcumResult = commandOlcum.ExecuteNonQuery();

                            if (olcumResult > 0)
                            {
                                MessageBox.Show("Kayıt başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                secenekleriTemizle();
                            }
                            else
                            {
                                MessageBox.Show("Olcumgecmisi eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int IDGetir(string kullaniciAdi)
        {
            int kullaniciID = 0;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Ayar))
            {
                connection.Open();
                string sqlQuery = "SELECT KullaniciID FROM KullaniciKayitlari WHERE KullaniciAdi = @KullaniciAdi";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi.Trim());
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        kullaniciID = Convert.ToInt32(reader["KullaniciID"]);
                    }
                }
            }

            return kullaniciID;
        }

        private bool MailBostaMi(string mailAdresi)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Ayar))
                {
                    connection.Open();
                    string sqlQuery = "SELECT COUNT(*) FROM KullaniciKayitlari WHERE Mail = @MailAdresi";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MailAdresi", mailAdresi);
                        int result = (int)command.ExecuteScalar(); // ExecuteScalar ile sadece tek bir değer alıyoruz.
                        if(result > 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool kAdiBostaMi(string kAdi)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Ayar))
                {
                    connection.Open();
                    string sqlQuery = "SELECT COUNT(*) FROM KullaniciKayitlari WHERE KullaniciAdi = @kadi";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@kadi", kAdi);
                        int result = (int)command.ExecuteScalar(); // ExecuteScalar ile sadece tek bir değer alıyoruz.
                        if (result > 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool TextBoxlarBosMu()
        {
            if (
                string.IsNullOrWhiteSpace(txtKadi.Text) && string.IsNullOrWhiteSpace(txtSifre.Text) && string.IsNullOrWhiteSpace(txtSifreTekrar.Text) && string.IsNullOrWhiteSpace(txtAd.Text) &&
                string.IsNullOrWhiteSpace(txtSoyad.Text) && string.IsNullOrWhiteSpace(txtKilo.Text) && string.IsNullOrWhiteSpace(txtBoy.Text) && string.IsNullOrWhiteSpace(txtBiceps.Text) &&
                string.IsNullOrWhiteSpace(txtOmuz.Text) && string.IsNullOrWhiteSpace(txtGogus.Text) && string.IsNullOrWhiteSpace(txtBel.Text)
                )
            {
                return true;
            }

            return false;
        }
        private void secenekleriTemizle()
        {
            txtKadi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSifreTekrar.Text = string.Empty;
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtKilo.Text = string.Empty;
            txtBoy.Text = string.Empty;
            txtBiceps.Text = string.Empty;
            txtOmuz.Text = string.Empty;
            txtGogus.Text = string.Empty;
            txtBel.Text = string.Empty;

            rbuttonErkek.Checked = false;
            rbuttonKadin.Checked = false;

            rdb1Ay.Checked = false;
            rdb3Ay.Checked = false;
            rdb6Ay.Checked = false;
            rdb12Ay.Checked = false;

            dateDogumGunu.EditValue = null;

            secilenFotograf = null;
            fotografSecildiMi = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
