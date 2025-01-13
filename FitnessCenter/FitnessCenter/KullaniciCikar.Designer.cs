namespace FitnessCenter
{
    partial class KullaniciCikar
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.lblMailGonderilecek = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGeri);
            this.panelControl1.Controls.Add(this.btnSil);
            this.panelControl1.Controls.Add(this.lblMailGonderilecek);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dataGridViewKullanicilar);
            this.panelControl1.Location = new System.Drawing.Point(113, 69);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1675, 724);
            this.panelControl1.TabIndex = 1;
            // 
            // btnGeri
            // 
            this.btnGeri.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGeri.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGeri.Appearance.Options.UseBackColor = true;
            this.btnGeri.Appearance.Options.UseFont = true;
            this.btnGeri.Appearance.Options.UseForeColor = true;
            this.btnGeri.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnGeri.Location = new System.Drawing.Point(528, 491);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(161, 68);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Appearance.Options.UseForeColor = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSil.Location = new System.Drawing.Point(1016, 491);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(161, 68);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblMailGonderilecek
            // 
            this.lblMailGonderilecek.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailGonderilecek.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMailGonderilecek.Appearance.Options.UseFont = true;
            this.lblMailGonderilecek.Appearance.Options.UseForeColor = true;
            this.lblMailGonderilecek.Location = new System.Drawing.Point(528, 335);
            this.lblMailGonderilecek.Name = "lblMailGonderilecek";
            this.lblMailGonderilecek.Size = new System.Drawing.Size(0, 58);
            this.lblMailGonderilecek.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(528, 205);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(590, 58);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kaydı silinecek kullanıcı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1560, 77);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Üye kaydını silmek istediğiniz kullanıcıyı seçiniz:";
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(51, 136);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.ReadOnly = true;
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(421, 441);
            this.dataGridViewKullanicilar.TabIndex = 0;
            // 
            // KullaniciCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitnessCenter.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1904, 871);
            this.Controls.Add(this.panelControl1);
            this.Name = "KullaniciCikar";
            this.Text = "KullaniciCikar";
            this.Load += new System.EventHandler(this.KullaniciCikar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.LabelControl lblMailGonderilecek;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
    }
}