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
    public partial class MotivasyonSozleri : Form
    {
        public MotivasyonSozleri()
        {
            InitializeComponent();
        }

        private void MotivasyonSozleri_Load(object sender, EventArgs e)
        {
            lblMotivasyonSozu.Text = GetRandomMotivasyonSozu();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnYeniSöz_Click(object sender, EventArgs e)
        {
            lblMotivasyonSozu.Text = GetRandomMotivasyonSozu();
        }
        private string GetRandomMotivasyonSozu()
        {
            string gununSozu = "";

            string query = "SELECT TOP 1 Soz FROM MotivasyonSozleri ORDER BY NEWID()";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Ayar))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                gununSozu = cmd.ExecuteScalar()?.ToString();
            }

            return gununSozu;
        }
    }
}
