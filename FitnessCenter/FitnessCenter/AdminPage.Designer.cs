namespace FitnessCenter
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKullaniciEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciCikar = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullanicilariGoruntule = new DevExpress.XtraBars.BarButtonItem();
            this.btnAntListGonder = new DevExpress.XtraBars.BarButtonItem();
            this.btnBesListGonder = new DevExpress.XtraBars.BarButtonItem();
            this.btnHasilatHesabi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDuyuruGonder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnCikisYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnKullaniciEkle,
            this.btnKullaniciCikar,
            this.btnKullanicilariGoruntule,
            this.btnAntListGonder,
            this.btnBesListGonder,
            this.btnHasilatHesabi,
            this.btnDuyuruGonder,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1904, 142);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Id = 8;
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            // 
            // btnKullaniciCikar
            // 
            this.btnKullaniciCikar.Caption = "Kullanıcı Çıkar";
            this.btnKullaniciCikar.Id = 2;
            this.btnKullaniciCikar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciCikar.ImageOptions.Image")));
            this.btnKullaniciCikar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullaniciCikar.ImageOptions.LargeImage")));
            this.btnKullaniciCikar.Name = "btnKullaniciCikar";
            this.btnKullaniciCikar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciCikar_ItemClick);
            // 
            // btnKullanicilariGoruntule
            // 
            this.btnKullanicilariGoruntule.Caption = "Kullanıcıları Görüntüle";
            this.btnKullanicilariGoruntule.Id = 3;
            this.btnKullanicilariGoruntule.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanicilariGoruntule.ImageOptions.Image")));
            this.btnKullanicilariGoruntule.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullanicilariGoruntule.ImageOptions.LargeImage")));
            this.btnKullanicilariGoruntule.Name = "btnKullanicilariGoruntule";
            this.btnKullanicilariGoruntule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullanicilariGoruntule_ItemClick);
            // 
            // btnAntListGonder
            // 
            this.btnAntListGonder.Caption = "Antrenman Listesi İletimi";
            this.btnAntListGonder.Id = 4;
            this.btnAntListGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAntListGonder.ImageOptions.Image")));
            this.btnAntListGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAntListGonder.ImageOptions.LargeImage")));
            this.btnAntListGonder.Name = "btnAntListGonder";
            this.btnAntListGonder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAntListGonder_ItemClick);
            // 
            // btnBesListGonder
            // 
            this.btnBesListGonder.Caption = "Beslenme Listesi İletimi";
            this.btnBesListGonder.Id = 5;
            this.btnBesListGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBesListGonder.ImageOptions.Image")));
            this.btnBesListGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBesListGonder.ImageOptions.LargeImage")));
            this.btnBesListGonder.Name = "btnBesListGonder";
            this.btnBesListGonder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBesListGonder_ItemClick);
            // 
            // btnHasilatHesabi
            // 
            this.btnHasilatHesabi.Caption = "Aylık Gelir Hesabı";
            this.btnHasilatHesabi.Id = 6;
            this.btnHasilatHesabi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHasilatHesabi.ImageOptions.Image")));
            this.btnHasilatHesabi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHasilatHesabi.ImageOptions.LargeImage")));
            this.btnHasilatHesabi.Name = "btnHasilatHesabi";
            this.btnHasilatHesabi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHasilatHesabi_ItemClick);
            // 
            // btnDuyuruGonder
            // 
            this.btnDuyuruGonder.Caption = "Duyuru Gönderme";
            this.btnDuyuruGonder.Id = 7;
            this.btnDuyuruGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuyuruGonder.ImageOptions.Image")));
            this.btnDuyuruGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDuyuruGonder.ImageOptions.LargeImage")));
            this.btnDuyuruGonder.Name = "btnDuyuruGonder";
            this.btnDuyuruGonder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDuyuruGonder_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ölçüm Güncelleme";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.ImageOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Yönetim";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKullanicilariGoruntule);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKullaniciCikar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Kullanıcı İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAntListGonder);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Antrenman İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBesListGonder);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Beslenme İşlemleri";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnHasilatHesabi);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Gelir Hesabı";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDuyuruGonder);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Duyuru Gönderme";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Black;
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis Dark";
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCikisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYap.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCikisYap.Appearance.Options.UseBackColor = true;
            this.btnCikisYap.Appearance.Options.UseFont = true;
            this.btnCikisYap.Appearance.Options.UseForeColor = true;
            this.btnCikisYap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnCikisYap.Location = new System.Drawing.Point(1729, 57);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(163, 54);
            this.btnCikisYap.TabIndex = 5;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 681);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciEkle;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciCikar;
        private DevExpress.XtraBars.BarButtonItem btnKullanicilariGoruntule;
        private DevExpress.XtraBars.BarButtonItem btnAntListGonder;
        private DevExpress.XtraBars.BarButtonItem btnBesListGonder;
        private DevExpress.XtraBars.BarButtonItem btnHasilatHesabi;
        private DevExpress.XtraBars.BarButtonItem btnDuyuruGonder;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnCikisYap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}