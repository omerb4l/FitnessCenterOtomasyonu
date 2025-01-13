namespace FitnessCenter
{
    partial class DuyuruGonder
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.txtBoxMetin = new System.Windows.Forms.RichTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblMailGonderilecek = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGeri);
            this.panelControl1.Controls.Add(this.btnGonder);
            this.panelControl1.Controls.Add(this.txtBoxMetin);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lblMailGonderilecek);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dataGridViewKullanicilar);
            this.panelControl1.Location = new System.Drawing.Point(59, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1790, 776);
            this.panelControl1.TabIndex = 0;
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
            this.btnGeri.Location = new System.Drawing.Point(1163, 630);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(169, 43);
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
            this.btnGonder.Location = new System.Drawing.Point(1505, 630);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(169, 43);
            this.btnGonder.TabIndex = 7;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtBoxMetin
            // 
            this.txtBoxMetin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMetin.Location = new System.Drawing.Point(1163, 358);
            this.txtBoxMetin.Name = "txtBoxMetin";
            this.txtBoxMetin.Size = new System.Drawing.Size(511, 249);
            this.txtBoxMetin.TabIndex = 5;
            this.txtBoxMetin.Text = "";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1163, 234);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(469, 84);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Lütfen gönderilecek mailin \r\niçeriğini doldurunuz:";
            // 
            // lblMailGonderilecek
            // 
            this.lblMailGonderilecek.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailGonderilecek.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMailGonderilecek.Appearance.Options.UseFont = true;
            this.lblMailGonderilecek.Appearance.Options.UseForeColor = true;
            this.lblMailGonderilecek.Location = new System.Drawing.Point(1163, 125);
            this.lblMailGonderilecek.Name = "lblMailGonderilecek";
            this.lblMailGonderilecek.Size = new System.Drawing.Size(0, 39);
            this.lblMailGonderilecek.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1163, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(511, 45);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mail gönderilecek kullanıcı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(110, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(911, 45);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Duyuru göndermek istediğiniz kullanıcıyı seçiniz:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(110, 125);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.ReadOnly = true;
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(557, 548);
            this.dataGridViewKullanicilar.TabIndex = 0;
            // 
            // DuyuruGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::FitnessCenter.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1904, 871);
            this.Controls.Add(this.panelControl1);
            this.Name = "DuyuruGonder";
            this.Text = "DuyuruGonder";
            this.Load += new System.EventHandler(this.DuyuruGonder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblMailGonderilecek;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private System.Windows.Forms.RichTextBox txtBoxMetin;
    }
}