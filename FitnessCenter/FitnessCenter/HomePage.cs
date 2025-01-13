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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        


        private void HomePage_Load(object sender, EventArgs e)
        {
            Background bg = new Background();
            bg.MdiParent = this;
            bg.Show();
            lblAdi.Text = AdDonder();
            lblSoyadi.Text = SoyAdDonder();
            pictureEdit1.Image = Image.FromFile(ImgPathDonder());
            
        }

        private string kullaniciAdi;
        
        public HomePage(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi; // Kullanıcı adını buraya aktar
        }

        private string AdDonder()
        {
            string connectionString = Properties.Settings.Default.Ayar;

            string selectQuery = "SELECT Ad FROM KullaniciKayitlari WHERE KullaniciAdi = @KullaniciAdi";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi); // Burada kullaniciAdi doğru bir parametre olarak geçilmeli

                conn.Open();

                var result = cmd.ExecuteScalar(); // Sadece bir değer döndürüyoruz, Ad'ı dönecek

                if (result != null)
                {
                    return result.ToString(); // Ad'ı döndür
                }
                else
                {
                    return "Kullanıcı bulunamadı"; // Eğer Ad bulunamazsa bu metni döndür
                }
            }

        }
        private string SoyAdDonder()
        {
            string connectionString = Properties.Settings.Default.Ayar;

            string selectQuery = "SELECT Soyad FROM KullaniciKayitlari WHERE KullaniciAdi = @KullaniciAdi";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                conn.Open();

                var result = cmd.ExecuteScalar(); // Sadece bir değer döndürüyoruz, Ad'ı dönecek

                if (result != null)
                {
                    return result.ToString(); // Ad'ı döndür
                }
                else
                {
                    return string.Empty; // Eğer Ad bulunamazsa boş dönebiliriz
                }
            }
        }
        private string ImgPathDonder()
        {
            string connectionString = Properties.Settings.Default.Ayar;

            string selectQuery = "SELECT FotoYolu FROM KullaniciKayitlari WHERE KullaniciAdi = @KullaniciAdi";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                conn.Open();

                var result = cmd.ExecuteScalar(); // Sadece bir değer döndürüyoruz, Ad'ı dönecek

                if (result != null)
                {
                    return result.ToString(); // Ad'ı döndür
                }
                else
                {
                    return string.Empty; // Eğer Ad bulunamazsa boş dönebiliriz
                }
            }
        }





        private void barToggleSwitchItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Close();
        }

        private void btnAntrenmanPlanim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AntrenmanList al = new AntrenmanList(kullaniciAdi);
            al.MdiParent = this;
            al.Show();
        }

        private void btnBeslenmeListem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BeslenmeList bl = new BeslenmeList(kullaniciAdi);
            bl.MdiParent = this;
            bl.Show();
        }

        private void btnIlerlemeTakibi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IlerlemeTakibi it = new IlerlemeTakibi(kullaniciAdi);
            it.MdiParent = this;
            it.Show();
        }

        private void btnMotivasyonSozleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MotivasyonSozleri ms = new MotivasyonSozleri();
            ms.MdiParent = this;
            ms.Show();
        }
    }
}
