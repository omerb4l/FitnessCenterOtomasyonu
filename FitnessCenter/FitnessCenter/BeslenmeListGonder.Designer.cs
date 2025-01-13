using System;
using System.Windows.Forms;

namespace FitnessCenter
{
    partial class BeslenmeListGonder
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
            this.lblDosyaAdi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnListeSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
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
            this.panelControl1.Controls.Add(this.lblDosyaAdi);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.btnListeSec);
            this.panelControl1.Controls.Add(this.btnGeri);
            this.panelControl1.Controls.Add(this.btnGonder);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lblMailGonderilecek);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dataGridViewKullanicilar);
            this.panelControl1.Location = new System.Drawing.Point(91, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1748, 749);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaAdi.Appearance.Options.UseFont = true;
            this.lblDosyaAdi.Location = new System.Drawing.Point(1110, 544);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(0, 45);
            this.lblDosyaAdi.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1110, 469);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(418, 45);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Seçilen dosyanın yolu:";
            // 
            // btnListeSec
            // 
            this.btnListeSec.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeSec.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListeSec.Appearance.Options.UseFont = true;
            this.btnListeSec.Appearance.Options.UseForeColor = true;
            this.btnListeSec.Location = new System.Drawing.Point(1265, 353);
            this.btnListeSec.Name = "btnListeSec";
            this.btnListeSec.Size = new System.Drawing.Size(276, 40);
            this.btnListeSec.TabIndex = 9;
            this.btnListeSec.Text = "Beslenme Listesini Seçiniz";
            this.btnListeSec.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGeri.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGeri.Appearance.Options.UseBackColor = true;
            this.btnGeri.Appearance.Options.UseFont = true;
            this.btnGeri.Appearance.Options.UseForeColor = true;
            this.btnGeri.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnGeri.Location = new System.Drawing.Point(1110, 637);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(171, 43);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGonder.Appearance.Options.UseBackColor = true;
            this.btnGonder.Appearance.Options.UseFont = true;
            this.btnGonder.Appearance.Options.UseForeColor = true;
            this.btnGonder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnGonder.Location = new System.Drawing.Point(1551, 637);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(171, 43);
            this.btnGonder.TabIndex = 7;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1110, 260);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(612, 42);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Lütfen gönderilecek listeyi seçiniz:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // lblMailGonderilecek
            // 
            this.lblMailGonderilecek.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailGonderilecek.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMailGonderilecek.Appearance.Options.UseFont = true;
            this.lblMailGonderilecek.Appearance.Options.UseForeColor = true;
            this.lblMailGonderilecek.Location = new System.Drawing.Point(1110, 138);
            this.lblMailGonderilecek.Name = "lblMailGonderilecek";
            this.lblMailGonderilecek.Size = new System.Drawing.Size(0, 45);
            this.lblMailGonderilecek.TabIndex = 3;
            this.lblMailGonderilecek.Click += new System.EventHandler(this.lblMailGonderilecek_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1110, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(511, 45);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mail gönderilecek kullanıcı:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(35, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(894, 45);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Listeyi göndermek istediğiniz kullanıcıyı seçiniz:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(35, 119);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.ReadOnly = true;
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(729, 561);
            this.dataGridViewKullanicilar.TabIndex = 0;
            // 
            // BeslenmeListGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitnessCenter.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1904, 871);
            this.Controls.Add(this.panelControl1);
            this.Name = "BeslenmeListGonder";
            this.Text = "BeslenmeListGonder";
            this.Load += new System.EventHandler(this.BeslenmeListGonder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridViewKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblMailGonderilecek;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
        private DevExpress.XtraEditors.SimpleButton btnListeSec;
        private DevExpress.XtraEditors.LabelControl lblDosyaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}