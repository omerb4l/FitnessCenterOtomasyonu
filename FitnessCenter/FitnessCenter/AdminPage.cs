using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class AdminPage : Form
    {
        string kullaniciAdi;
        public AdminPage(string KullaniciAdi)
        {
            InitializeComponent();
            kullaniciAdi = KullaniciAdi;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            Background bg = new Background();
            bg.MdiParent = this;
            bg.Show();
        }


        private void btnDuyuruGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DuyuruGonder dg = new DuyuruGonder();
            dg.MdiParent = this;
            dg.Show();
        }

        private void btnHasilatHesabi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AylikGelirHesabi agh = new AylikGelirHesabi();
            agh.MdiParent = this;
            agh.Show();
        }

        private void btnBesListGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BeslenmeListGonder blg = new BeslenmeListGonder();
            blg.MdiParent = this;
            blg.Show();
        }

        private void btnAntListGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AntrenmanListGonder alg = new AntrenmanListGonder();
            alg.MdiParent = this;
            alg.Show();
        }

        private void btnKullaniciCikar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KullaniciCikar kc = new KullaniciCikar();
            kc.MdiParent = this;
            kc.Show();
        }

        private void btnKullanicilariGoruntule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KullanicilariGoruntule kg = new KullanicilariGoruntule();
            kg.MdiParent = this;
            kg.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OlcumGuncelleme og = new OlcumGuncelleme();
            og.MdiParent = this;
            og.Show();
        }
    }
}
