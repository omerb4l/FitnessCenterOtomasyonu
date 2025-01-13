using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraCharts;
using System.Windows.Forms;
using System.Drawing;

namespace FitnessCenter
{
    public partial class IlerlemeTakibi : Form
    {

        private string connectionString = Properties.Settings.Default.Ayar;
        private SqlConnection _connection;
        private string kullaniciAdi;
        private int kullaniciID;

        public IlerlemeTakibi()
        {
            InitializeComponent();
        }


        public IlerlemeTakibi(string kadi)
        {
            kullaniciAdi = kadi; // Constructor ile gelen kullanıcı adını alıyoruz
            InitializeComponent();
        }

        private void IlerlemeTakibi_Load(object sender, EventArgs e)
        {
            _connection = new SqlConnection(connectionString);

            // Kullanıcı ID'yi bul
            kullaniciID = GetKullaniciID(kullaniciAdi);

            if (kullaniciID > 0)
            {

            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!");
                this.Close();
            }
        }

        private int GetKullaniciID(string kullaniciAdi)
        {
            try
            {
                _connection.Open();
                string query = "SELECT ID FROM KullaniciKayitlari WHERE KullaniciAdi = @KullaniciAdi";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return -1;
            }
            finally
            {
                _connection.Close();
            }
        }

        private DataTable GetOlcumVerileri(string olcumTuru)
        {
            DataTable dt = new DataTable();

            try
            {
                _connection.Open();
                string query = $@"
                    SELECT Tarih, {olcumTuru} 
                    FROM OlcumGecmisi 
                    WHERE KullaniciID = @KullaniciID 
                    ORDER BY Tarih ASC";

                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return dt;
        }

        private void CreateChartInPanel(string olcumTuru)
        {
            // Panel içeriğini temizle
            panelChart.Controls.Clear();

            // Yeni Chart oluştur
            ChartControl chart = new ChartControl();
            chart.Dock = DockStyle.Fill;

            // Seriyi tanımla (Çizgi tipi grafik için)
            Series series = new Series(olcumTuru, ViewType.Line);
            chart.Series.Add(series);

            // Grafik başlığı ve diğer ayarları
            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chart.Titles.Add(new ChartTitle { Text = $"{olcumTuru} Değişim Grafiği" });

            // Verileri al
            DataTable data = GetOlcumVerileri(olcumTuru);

            if (data.Rows.Count > 0)
            {
                // Verileri seriye ekle
                foreach (DataRow row in data.Rows)
                {
                    DateTime tarih = Convert.ToDateTime(row["Tarih"]);
                    decimal olcumDegeri = Convert.ToDecimal(row[olcumTuru]);

                    // Tarih ve ölçüm değerlerini grafiğe ekle
                    series.Points.Add(new SeriesPoint(tarih, olcumDegeri));
                }

                // X ekseninde tarihi göster
                XYDiagram diagram = (XYDiagram)chart.Diagram;
                diagram.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.None;
                diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day;
                diagram.AxisX.Label.TextPattern = "{A:dd/MM/yyyy}";
            }
            else
            {
                MessageBox.Show($"{olcumTuru} için veri bulunamadı.");
                return;
            }

            // Grafiği panele ekle
            panelChart.Controls.Add(chart);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CreateChartInPanel("Boy");
        }

        private void btnKilo_Click(object sender, EventArgs e)
        {
            CreateChartInPanel("Kilo");
        }

        private void btnOmuz_Click(object sender, EventArgs e)
        {
            CreateChartInPanel("Omuz");
        }

        private void btnBel_Click(object sender, EventArgs e)
        {
            CreateChartInPanel("Bel");
        }

        private void btnBiceps_Click(object sender, EventArgs e)
        {
            CreateChartInPanel("Biceps");
        }

        private void btnGogus_Click(object sender, EventArgs e)
        {
            CreateChartInPanel("Gogus");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
