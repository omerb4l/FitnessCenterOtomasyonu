using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class KullaniciCikar : Form
    {
        public KullaniciCikar()
        {
            InitializeComponent();
        }

        private void dataGridViewKullanicilar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewKullanicilar.Columns[e.ColumnIndex].Name == "Ad" || dataGridViewKullanicilar.Columns[e.ColumnIndex].Name == "Soyad")
                {
                    if (string.IsNullOrEmpty(dataGridViewKullanicilar.Rows[e.RowIndex].Cells["Ad"].Value?.ToString()) ||
                        string.IsNullOrEmpty(dataGridViewKullanicilar.Rows[e.RowIndex].Cells["Soyad"].Value?.ToString()))
                    {
                        e.CellStyle.ForeColor = Color.Gray;  // Metin rengi gri olabilir
                        e.CellStyle.BackColor = Color.LightGray;  // Arka plan rengi gri
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Orange;  // Metin rengi
                        e.CellStyle.BackColor = Color.Black;  // Arka plan rengi
                    }
                }
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewKullanicilar.CurrentRow != null)
            {
                // Seçili satırdaki 'Ad' ve 'Soyad' bilgilerini al
                string secilenAd = dataGridViewKullanicilar.CurrentRow.Cells["Ad"].Value.ToString();
                string secilenSoyad = dataGridViewKullanicilar.CurrentRow.Cells["Soyad"].Value.ToString();

                // MSSQL bağlantı dizesi
                string connectionString = Properties.Settings.Default.Ayar;

                // Kullanıcı ID'sini almak için sorgu
                string idSorgu = "SELECT ID FROM KullaniciKayitlari WHERE Ad = @Ad AND Soyad = @Soyad";
                string silOlcumGecmisi = "DELETE FROM OlcumGecmisi WHERE KullaniciID = @KullaniciID";
                string silKullanici = "DELETE FROM KullaniciKayitlari WHERE ID = @ID";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Kullanıcı ID'sini getir
                        SqlCommand idCmd = new SqlCommand(idSorgu, conn);
                        idCmd.Parameters.AddWithValue("@Ad", secilenAd);
                        idCmd.Parameters.AddWithValue("@Soyad", secilenSoyad);

                        object kullaniciIdObj = idCmd.ExecuteScalar();
                        if (kullaniciIdObj != null)
                        {
                            int kullaniciID = Convert.ToInt32(kullaniciIdObj);

                            // OlcumGecmisi tablosundan ilgili kayıtları sil
                            SqlCommand silOlcumCmd = new SqlCommand(silOlcumGecmisi, conn);
                            silOlcumCmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                            silOlcumCmd.ExecuteNonQuery();

                            // KullaniciKayitlari tablosundan kullanıcıyı sil
                            SqlCommand silKullaniciCmd = new SqlCommand(silKullanici, conn);
                            silKullaniciCmd.Parameters.AddWithValue("@ID", kullaniciID);
                            int rowsAffected = silKullaniciCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Kullanıcı ve ilişkili kayıtlar başarıyla silindi.");
                                KullaniciTablosunuDoldur(); // Tabloyu yeniden doldurun
                            }
                            else
                            {
                                MessageBox.Show("Silme işlemi başarısız.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Silinecek bir kullanıcı seçmediniz.");
            }
        }

        private int? IDGetir(string ad, string soyad)
        {
            string connectionString = Properties.Settings.Default.Ayar;
            string sorgu = "SELECT ID FROM KullaniciKayitlari WHERE Ad = @Ad AND Soyad = @Soyad";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);

                    conn.Open();
                    object sonuc = cmd.ExecuteScalar(); // ID değerini al

                    if (sonuc != null)
                    {
                        return Convert.ToInt32(sonuc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID getirilemedi: " + ex.Message);
            }

            return null; // Eğer ID bulunamazsa
        }



        private void KullaniciCikar_Load(object sender, EventArgs e)
        {
            dataGridViewKullanicilar.AllowUserToAddRows = false;
            KullaniciTablosunuDoldur();
            dataGridViewKullanicilar.SelectionChanged += dataGridViewKullanicilar_SelectionChanged;
            dataGridViewKullanicilar.CellFormatting += dataGridViewKullanicilar_CellFormatting; // Olay ekleme
            DataGridViewStilAyarla();
        }
    }
}
