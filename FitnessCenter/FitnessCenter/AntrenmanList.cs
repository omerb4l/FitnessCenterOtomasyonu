using DevExpress.Pdf;
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
    public partial class AntrenmanList : Form
    {
        public AntrenmanList()
        {
            InitializeComponent();
        }

        string kullaniciAdi;
        public AntrenmanList(string kadi)
        {
            kullaniciAdi = kadi;
            InitializeComponent();
        }
        private void AntrenmanList_Load(object sender, EventArgs e)
        {
            ConfigurePdfViewer();
            string pdfPath = AntrenmanPathDonder(kullaniciAdi);

            if (!string.IsNullOrEmpty(pdfPath) && File.Exists(pdfPath))
            {
                pdfAntrenmanList.LoadDocument(pdfPath); // PDF dosyasını yükle
            }
            else
            {
                MessageBox.Show("Antrenman dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurePdfViewer()
        {
            // Gezinme panelini gizle
            pdfAntrenmanList.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
        }

        private string AntrenmanPathDonder(string kullaniciAdi)
        {
            string connectionString = Properties.Settings.Default.Ayar; // Veritabanı bağlantı ayarı
            string selectQuery = "SELECT AntrenmanPath FROM KullaniciKayitlari WHERE KullaniciAdi = @KullaniciAdi";

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

        private void pdfViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
