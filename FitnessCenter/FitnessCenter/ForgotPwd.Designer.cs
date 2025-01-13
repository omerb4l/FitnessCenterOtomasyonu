namespace FitnessCenter
{
    partial class ForgotPwd
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
            this.txtEposta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Black;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.txtEposta);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pictureEdit3);
            this.panelControl1.Controls.Add(this.btnGeri);
            this.panelControl1.Controls.Add(this.btnGirisYap);
            this.panelControl1.Location = new System.Drawing.Point(150, 67);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(702, 578);
            this.panelControl1.TabIndex = 2;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(123, 273);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Properties.Appearance.Options.UseFont = true;
            this.txtEposta.Size = new System.Drawing.Size(441, 36);
            this.txtEposta.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(93, 167);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(503, 71);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Lütfen şifre bilginizin gönderilmesini\r\n istediğiniz e-posta adresini girin:";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = global::FitnessCenter.Properties.Resources.logo;
            this.pictureEdit3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureEdit3.Location = new System.Drawing.Point(293, 31);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit3.TabIndex = 5;
            // 
            // btnGeri
            // 
            this.btnGeri.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnGeri.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGeri.Appearance.Options.UseBackColor = true;
            this.btnGeri.Appearance.Options.UseFont = true;
            this.btnGeri.Appearance.Options.UseForeColor = true;
            this.btnGeri.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnGeri.Location = new System.Drawing.Point(186, 406);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(307, 43);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Giriş Ekranına Geri Dön";
            this.btnGeri.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnGirisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGirisYap.Appearance.Options.UseBackColor = true;
            this.btnGirisYap.Appearance.Options.UseFont = true;
            this.btnGirisYap.Appearance.Options.UseForeColor = true;
            this.btnGirisYap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnGirisYap.Location = new System.Drawing.Point(186, 348);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(307, 43);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Gönder";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Black;
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis Dark";
            // 
            // ForgotPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1011, 726);
            this.Controls.Add(this.panelControl1);
            this.Name = "ForgotPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPwd";
            this.Load += new System.EventHandler(this.ForgotPwd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
        private DevExpress.XtraEditors.TextEdit txtEposta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}