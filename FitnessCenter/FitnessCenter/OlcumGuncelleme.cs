using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class OlcumGuncelleme : Form
    {
        public OlcumGuncelleme()
        {
            InitializeComponent();
        }

        private SqlConnection _connection;

        private void OlcumGuncelleme_Load(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını başlat
            _connection = new SqlConnection(Properties.Settings.Default.Ayar);
            KullaniciListesiniDoldur();
            DataGridViewStilAyarla();
        }

        private void KullaniciListesiniDoldur()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sorgu = "SELECT ID, Ad, Soyad FROM KullaniciKayitlari WHERE KullaniciAdi != 'admin'";
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbKullaniciSecimi.Properties.Items.Clear(); // ComboBoxEdit için
                    foreach (DataRow row in dt.Rows)
                    {
                        cmbKullaniciSecimi.Properties.Items.Add(new KeyValuePair<int, string>(
                            Convert.ToInt32(row["ID"]),
                            $"{row["Ad"]} {row["Soyad"]}"
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void DataGridViewStilAyarla()
        {
            // Genel hücre stili
            dataOlcumGecmisi.DefaultCellStyle.BackColor = Color.Black;
            dataOlcumGecmisi.DefaultCellStyle.ForeColor = Color.Orange;
            dataOlcumGecmisi.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataOlcumGecmisi.DefaultCellStyle.SelectionBackColor = Color.Black;
            dataOlcumGecmisi.DefaultCellStyle.SelectionForeColor = Color.Orange;

            // Alternatif satır stili
            dataOlcumGecmisi.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dataOlcumGecmisi.AlternatingRowsDefaultCellStyle.ForeColor = Color.Orange;

            // Sütun başlık stili
            dataOlcumGecmisi.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataOlcumGecmisi.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dataOlcumGecmisi.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataOlcumGecmisi.EnableHeadersVisualStyles = false;

            // Grid çizgileri ve kenar çizgileri
            dataOlcumGecmisi.GridColor = Color.Orange;
            dataOlcumGecmisi.BorderStyle = BorderStyle.None;

            // Satır seçimini temizle
            dataOlcumGecmisi.ClearSelection();

            // Sütun genişleme modu
            dataOlcumGecmisi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ReadOnly özelliğini etkinleştirerek düzenlemeyi kapat
            dataOlcumGecmisi.ReadOnly = true;
        }

        private string connectionString = Properties.Settings.Default.Ayar;

        private void OlcumGecmisiniDoldur(int kullaniciID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sorgu = "SELECT * FROM OlcumGecmisi WHERE KullaniciID = @KullaniciID";
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataOlcumGecmisi.DataSource = dt; // Grid'e verileri bağla
                    }
                    else
                    {
                        MessageBox.Show("Veri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbKullaniciSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen kullanıcının ölçüm geçmişini doldur
            if (cmbKullaniciSecimi.SelectedItem != null)
            {
                var seciliKullaniciID = ((KeyValuePair<int, string>)cmbKullaniciSecimi.SelectedItem).Key;
                OlcumGecmisiniDoldur(seciliKullaniciID); // Bu metodu çağırarak bilgileri grid'e doldurabilirsiniz
            }
        }


        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbKullaniciSecimi.SelectedItem != null)
                {
                    if (!AreTextBoxesValid())
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // İşlemi durdur
                    }

                    var seciliKullaniciID = ((KeyValuePair<int, string>)cmbKullaniciSecimi.SelectedItem).Key;

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Ayar))
                    {
                        connection.Open();

                        // Ölçüm Gecmisi Güncelleme Sorgusu
                        string insertQuery = @"
                                    INSERT INTO OlcumGecmisi (KullaniciID, Tarih, Boy, Kilo, Omuz, Bel, Biceps, Gogus)
                                    VALUES (@KullaniciID, @Tarih, @Boy, @Kilo, @Omuz, @Bel, @Biceps, @Gogus)";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@KullaniciID", seciliKullaniciID);
                            command.Parameters.AddWithValue("@Tarih", DateTime.Now); // Şu anki tarih
                            command.Parameters.AddWithValue("@Boy", Convert.ToDecimal(txtBoy.Text.Trim()));
                            command.Parameters.AddWithValue("@Kilo", Convert.ToDecimal(txtKilo.Text.Trim()));
                            command.Parameters.AddWithValue("@Omuz", Convert.ToDecimal(txtOmuz.Text.Trim()));
                            command.Parameters.AddWithValue("@Bel", Convert.ToDecimal(txtBel.Text.Trim()));
                            command.Parameters.AddWithValue("@Biceps", Convert.ToDecimal(txtBiceps.Text.Trim()));
                            command.Parameters.AddWithValue("@Gogus", Convert.ToDecimal(txtGogus.Text.Trim()));

                            command.ExecuteNonQuery();
                        }

                        // Kullanıcı Kaydı Güncelleme Sorgusu
                        string updateQuery = @"
                                    UPDATE KullaniciKayitlari
                                    SET Boy = @Boy, Kilo = @Kilo, Omuz = @Omuz, Bel = @Bel, Biceps = @Biceps, Gogus = @Gogus
                                    WHERE ID = @KullaniciID";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@KullaniciID", seciliKullaniciID);
                            command.Parameters.AddWithValue("@Boy", Convert.ToDecimal(txtBoy.Text.Trim()));
                            command.Parameters.AddWithValue("@Kilo", Convert.ToDecimal(txtKilo.Text.Trim()));
                            command.Parameters.AddWithValue("@Omuz", Convert.ToDecimal(txtOmuz.Text.Trim()));
                            command.Parameters.AddWithValue("@Bel", Convert.ToDecimal(txtBel.Text.Trim()));
                            command.Parameters.AddWithValue("@Biceps", Convert.ToDecimal(txtBiceps.Text.Trim()));
                            command.Parameters.AddWithValue("@Gogus", Convert.ToDecimal(txtGogus.Text.Trim()));

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Ölçüm güncellemesi ve yeni kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OlcumGecmisiniDoldur(seciliKullaniciID); // Grid'e güncel ölçüm geçmişini doldur
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir kullanıcı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool AreTextBoxesValid()
        {
            // Gerekli alanların dolu olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtBoy.Text) ||
                string.IsNullOrWhiteSpace(txtKilo.Text) ||
                string.IsNullOrWhiteSpace(txtOmuz.Text) ||
                string.IsNullOrWhiteSpace(txtBel.Text) ||
                string.IsNullOrWhiteSpace(txtBiceps.Text) ||
                string.IsNullOrWhiteSpace(txtGogus.Text))
            {
                return false; // Bir alan boşsa, hata döndür
            }
            return true; // Her şey doğru girilmişse true döndür
        }
        private void ClearTextBoxes()
        {
            txtBoy.Text = "";
            txtKilo.Text = "";
            txtOmuz.Text = "";
            txtBel.Text = "";
            txtBiceps.Text = "";
            txtGogus.Text = "";
        }

        private void gridOlcumGecmisi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
