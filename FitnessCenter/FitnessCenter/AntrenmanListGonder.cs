using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class AntrenmanListGonder : Form
    {
        public AntrenmanListGonder()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string secilenAd = dataGridViewKullanicilar.CurrentRow.Cells["Ad"].Value.ToString();
            string secilenSoyad = dataGridViewKullanicilar.CurrentRow.Cells["Soyad"].Value.ToString();
            string aliciMail = MailAdresiGetir(secilenAd, secilenSoyad); // E-posta adresini getirin

            if (string.IsNullOrEmpty(lblDosyaAdi.Text))
            {
                MessageBox.Show("Lütfen bir dosya seçin.");
                return;
            }

            string dosyaPath = lblDosyaAdi.Text; // Seçilen dosya yolunu al

            // E-posta gönderimi
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("fitnesscenter230@gmail.com"),
                    Subject = "Antrenman Listesi",
                    Body = "Antrenman listesi dosyanızı ekte bulabilirsiniz."
                };
                mail.To.Add(aliciMail); // Alıcı e-posta adresini ekleyin
                mail.Attachments.Add(new Attachment(dosyaPath));

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("fitnesscenter230@gmail.com", "diegqpjxzfjbqlis"); // SMTP hesap bilgileri
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }

                MessageBox.Show("E-posta başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilirken hata oluştu: " + ex.Message);
            }

            string connectionString = Properties.Settings.Default.Ayar;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE KullaniciKayitlari SET AntrenmanPath = @AntrenmanPath WHERE Mail = @Mail";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@AntrenmanPath", dosyaPath); // Dosya yolunu ekliyoruz
                    cmd.Parameters.AddWithValue("@Mail", aliciMail); // E-posta adresini ekliyoruz

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private string MailAdresiGetir(string ad, string soyad)
        {
            string mail = "";
            string connectionString = Properties.Settings.Default.Ayar;
            string sorgu = "SELECT Mail FROM KullaniciKayitlari WHERE Ad = @Ad AND Soyad = @Soyad";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);

                    conn.Open();
                    mail = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mail;
        }

        private void KullaniciTablosunuDoldur()
        {
            // MSSQL bağlantı dizesi
            string connectionString = Properties.Settings.Default.Ayar;

            // SQL sorgusu
            string sorgu = "SELECT Ad, Soyad FROM KullaniciKayitlari WHERE Ad != 'Admin'";

            try
            {
                // Bağlantıyı oluştur
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Komut ve adaptör ayarları
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    // DataTable ile verileri doldur
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DataGridView'e verileri bağla
                    dataGridViewKullanicilar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını göster
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void dataGridViewKullanicilar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKullanicilar.CurrentRow != null)
            {
                // Seçilen satırdaki 'Ad' bilgisini alıyoruz
                string secilenAd = dataGridViewKullanicilar.CurrentRow.Cells["Ad"].Value.ToString();
                string secilenSoyad = dataGridViewKullanicilar.CurrentRow.Cells["Soyad"].Value.ToString();

                // Kullanıcı bilgilerini label ile gösterebilirsiniz
                lblMailGonderilecek.Text = $"{secilenAd} {secilenSoyad}";

                // Mail adresini al ve sakla
                string mailAdresi = MailAdresiGetir(secilenAd, secilenSoyad);
            }
        }

        private void dataGridViewKullanicilar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Sadece Ad ve Soyad sütunları için geçerli olacak
                if (dataGridViewKullanicilar.Columns[e.ColumnIndex].Name == "Ad" || dataGridViewKullanicilar.Columns[e.ColumnIndex].Name == "Soyad")
                {
                    e.CellStyle.ForeColor = Color.Orange;  // Metin rengi
                    e.CellStyle.BackColor = Color.Black;  // Arka plan rengi
                }
            }
        }

        private void DataGridViewStilAyarla()
        {
            // Genel hücre stili
            dataGridViewKullanicilar.DefaultCellStyle.BackColor = Color.Black;
            dataGridViewKullanicilar.DefaultCellStyle.ForeColor = Color.Orange;
            dataGridViewKullanicilar.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridViewKullanicilar.DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridViewKullanicilar.DefaultCellStyle.SelectionForeColor = Color.Orange;

            // Alternatif satır stili
            dataGridViewKullanicilar.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dataGridViewKullanicilar.AlternatingRowsDefaultCellStyle.ForeColor = Color.Orange;

            // Sütun başlık stili
            dataGridViewKullanicilar.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridViewKullanicilar.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dataGridViewKullanicilar.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewKullanicilar.EnableHeadersVisualStyles = false;

            // Grid çizgileri ve kenar çizgileri
            dataGridViewKullanicilar.GridColor = Color.Orange;
            dataGridViewKullanicilar.BorderStyle = BorderStyle.None;

            // Satır seçimini temizle
            dataGridViewKullanicilar.ClearSelection();

            // Sütun genişleme modu
            dataGridViewKullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void AntrenmanListGonder_Load(object sender, EventArgs e)
        {
            dataGridViewKullanicilar.AllowUserToAddRows = false;
            KullaniciTablosunuDoldur();
            dataGridViewKullanicilar.SelectionChanged += dataGridViewKullanicilar_SelectionChanged;
            dataGridViewKullanicilar.CellFormatting += dataGridViewKullanicilar_CellFormatting; // Olay ekleme
            DataGridViewStilAyarla();
        }

        private void btnListeSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files|*.pdf|Word Files|*.docx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dosyaPath = openFileDialog.FileName;
                    lblDosyaAdi.Text = dosyaPath;
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
