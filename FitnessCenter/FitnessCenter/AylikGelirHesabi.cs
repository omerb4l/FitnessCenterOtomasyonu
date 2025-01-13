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
    public partial class AylikGelirHesabi : Form
    {
        public AylikGelirHesabi()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AylikGelirHesabi_Load(object sender, EventArgs e)
        {
            Hesapla();
        }
        private void Hesapla()
        {
            int aktifKullaniciSayisi = 0;
            decimal aylikKazanc = 0m;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Ayar))
            {
                connection.Open();

                // Aktif kullanıcı sayısını almak
                SqlCommand aktifKullaniciCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM KullaniciKayitlari WHERE BitisTarihi >= GETDATE() AND UyelikDurumu = 1 AND KullaniciAdi <> 'admin'", connection);
                aktifKullaniciSayisi = (int)aktifKullaniciCmd.ExecuteScalar();

                // Güncellenmiş fiyatlandırma bilgileri
                decimal fiyat1Ay = 800m;   // 1 ay için fiyat
                decimal fiyat3Ay = 2100m;  // 3 ay için fiyat
                decimal fiyat6Ay = 3900m;  // 6 ay için fiyat
                decimal fiyat12Ay = 7200m; // 12 ay için fiyat

                // Aylık gelir hesaplama
                SqlCommand geliriHesaplaCmd = new SqlCommand(@"
                SELECT SUM(
                CASE 
                    WHEN UyelikSuresi = 1 THEN @Fiyat1Ay
                    WHEN UyelikSuresi = 3 THEN @Fiyat3Ay / 3
                    WHEN UyelikSuresi = 6 THEN @Fiyat6Ay / 6
                    WHEN UyelikSuresi = 12 THEN @Fiyat12Ay / 12
                    ELSE 0 
                END
                ) AS AylikGelir
                FROM KullaniciKayitlari
                WHERE BitisTarihi >= GETDATE() AND UyelikDurumu = 1 AND KullaniciAdi <> 'admin'", connection);

                // Parametreler
                geliriHesaplaCmd.Parameters.AddWithValue("@Fiyat1Ay", fiyat1Ay);
                geliriHesaplaCmd.Parameters.AddWithValue("@Fiyat3Ay", fiyat3Ay);
                geliriHesaplaCmd.Parameters.AddWithValue("@Fiyat6Ay", fiyat6Ay);
                geliriHesaplaCmd.Parameters.AddWithValue("@Fiyat12Ay", fiyat12Ay);

                // Aylık kazancı al
                object result = geliriHesaplaCmd.ExecuteScalar();
                aylikKazanc = result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
            }

            // Sonuçları ekrana yazdır
            lblKullaniciSayisi.Text = aktifKullaniciSayisi.ToString();
            lblAylikGelir.Text = aylikKazanc.ToString("C"); // Para birimi formatında gösterir.
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
