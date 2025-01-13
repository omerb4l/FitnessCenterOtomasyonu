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
    public partial class KullanicilariGoruntule : Form
    {
        public KullanicilariGoruntule()
        {
            InitializeComponent();
        }

        private void KullanicilariGoruntule_Load(object sender, EventArgs e)
        {
            KullaniciTablosunuDoldur(); // Veritabanından verileri yükle
            DataGridViewAyarlariniYap(); // Tablonun sadece görüntüleme için ayarlanması
            DataGridViewStilAyarla(); // Şık bir tasarım için stiller
        }

        private void KullaniciTablosunuDoldur()
        {
            // MSSQL bağlantı dizesi
            string connectionString = Properties.Settings.Default.Ayar;

            // SQL sorgusu
            string sorgu = @"
                            SELECT 
                            Ad, 
                            Soyad, 
                            Mail AS [E-posta], 
                            KayitTarihi AS [Üyelik Başlangıç Tarihi], 
                            BitisTarihi AS [Üyelik Bitiş Tarihi], 
                            CASE 
                                WHEN BitisTarihi >= GETDATE() THEN 'Aktif' 
                                ELSE 'Süresi Doldu' 
                            END AS [Üyelik Durumu],
                            DATEDIFF(DAY, GETDATE(), BitisTarihi) AS [Kalan Gün Sayısı],
                            UyelikSuresi AS [Üyelik Süresi]
                            FROM 
                            KullaniciKayitlari
                            WHERE 
                            KullaniciAdi != 'Admin'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DataGridView'e verileri bağla
                    dataGridViewKullanicilar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını göster
                MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewAyarlariniYap()
        {
            dataGridViewKullanicilar.ReadOnly = true; // Yalnızca okuma
            dataGridViewKullanicilar.AllowUserToAddRows = false; // Yeni satır eklenmesini engelle
            dataGridViewKullanicilar.AllowUserToDeleteRows = false; // Silme işlemini engelle
            dataGridViewKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Tüm satır seçimi
            dataGridViewKullanicilar.MultiSelect = false; // Birden fazla seçim yapılmasını engelle
            dataGridViewKullanicilar.AllowUserToResizeRows = false; // Satır boyutlandırmayı kapat
            dataGridViewKullanicilar.AllowUserToResizeColumns = true; // İsteğe bağlı: Sütun boyutlandırmayı açık bırakabilirsiniz
            dataGridViewKullanicilar.RowHeadersVisible = false; // Satır başlıklarını gizle
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
