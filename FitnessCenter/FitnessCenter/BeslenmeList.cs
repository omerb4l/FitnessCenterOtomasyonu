using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class BeslenmeList : Form
    {
        public BeslenmeList()
        {
            InitializeComponent();
        }

        string kullaniciAdi;
        public BeslenmeList(string kadi)
        {
            kullaniciAdi = kadi;
            InitializeComponent();
        }

        private void BeslenmeList_Load(object sender, EventArgs e)
        {
            ConfigurePdfViewer();
            string pdfPath = BeslenmePathDonder(kullaniciAdi);

            if (!string.IsNullOrEmpty(pdfPath) && File.Exists(pdfPath))
            {
                pdfBeslenmeList.LoadDocument(pdfPath); // PDF dosyasını yükle
            }
            else
            {
                MessageBox.Show("Antrenman dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurePdfViewer()
        {
            // Gezinme panelini gizle
            pdfBeslenmeList.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
        }

        private string BeslenmePathDonder(string kullaniciAdi)
        {
            string connectionString = Properties.Settings.Default.Ayar; // Veritabanı bağlantı ayarı
            string selectQuery = "SELECT BeslenmePath FROM KullaniciKayitlari WHERE KullaniciAdi = @KullaniciAdi";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString(); // PDF yolunu döndür
                }
                else
                {
                    return string.Empty; // Dosya yolu bulunamazsa boş döndür
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
