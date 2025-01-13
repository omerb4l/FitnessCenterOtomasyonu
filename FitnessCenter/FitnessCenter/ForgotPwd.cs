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
using System.Net.Mail;
using System.Net;

namespace FitnessCenter
{
    public partial class ForgotPwd : Form
    {
        public ForgotPwd()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string mailAdresi = txtEposta.Text.Trim();
            if (string.IsNullOrEmpty(mailAdresi))
            {
                MessageBox.Show("Lütfen e-posta adresinizi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı kontrolü
            if (KullaniciMailAdresiVarMi(mailAdresi))
            {
                // E-posta gönderme işlemi
                string sifre = SifreGetir(mailAdresi);

                if (sifre != null)
                {
                    bool mailGonderildi = SifreYenilemeMailiGonder(mailAdresi, sifre);

                    if (mailGonderildi)
                    {
                        MessageBox.Show("Şifreniz e-posta adresinize gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Formu kapat
                        LoginPage lp = new LoginPage();
                        lp.Show();
                    }
                    else
                    {
                        MessageBox.Show("E-posta gönderilemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEposta.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Şifre bulunamadı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu e-posta adresi ile kayıtlı bir kullanıcı bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEposta.Text = "";
            }
        }

        private bool KullaniciMailAdresiVarMi(string mailAdresi)
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
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string SifreGetir(string mailAdresi)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Ayar))
                {
                    connection.Open();
                    string sqlQuery = "SELECT Sifre FROM KullaniciKayitlari WHERE Mail = @MailAdresi";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MailAdresi", mailAdresi);
                        var sifre = command.ExecuteScalar(); // ExecuteScalar ile şifreyi alıyoruz.

                        return sifre != null ? sifre.ToString() : null; // Şifreyi döndürüyoruz
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool SifreYenilemeMailiGonder(string mailAdresi, string sifre)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(mailAdresi);
                mail.From = new MailAddress("fitnesscenter230@gmail.com");  // Gönderen e-posta adresi
                mail.Subject = "Şifre Talebi";
                mail.Body = $"Hesabınızın şifresi: {sifre}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,  // TLS portu
                    Credentials = new NetworkCredential("fitnesscenter230@gmail.com", "diegqpjxzfjbqlis"),  // E-posta ve şifre
                    EnableSsl = true
                };

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void ForgotPwd_Load(object sender, EventArgs e)
        {

        }
    }
}
