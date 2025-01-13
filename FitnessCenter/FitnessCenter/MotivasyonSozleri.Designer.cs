namespace FitnessCenter
{
    partial class MotivasyonSozleri
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnYeniSöz = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMotivasyonSozu = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(552, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(800, 77);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Günün motivasyon sözü:";
            // 
            // btnYeniSöz
            // 
            this.btnYeniSöz.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYeniSöz.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniSöz.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnYeniSöz.Appearance.Options.UseBackColor = true;
            this.btnYeniSöz.Appearance.Options.UseFont = true;
            this.btnYeniSöz.Appearance.Options.UseForeColor = true;
            this.btnYeniSöz.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnYeniSöz.Location = new System.Drawing.Point(1640, 743);
            this.btnYeniSöz.Name = "btnYeniSöz";
            this.btnYeniSöz.Size = new System.Drawing.Size(137, 50);
            this.btnYeniSöz.TabIndex = 21;
            this.btnYeniSöz.Text = "Yeni Söz";
            this.btnYeniSöz.Click += new System.EventHandler(this.btnYeniSöz_Click);
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
            this.btnGeri.Location = new System.Drawing.Point(124, 743);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(137, 50);
            this.btnGeri.TabIndex = 22;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblMotivasyonSozu);
            this.panel1.Location = new System.Drawing.Point(124, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 574);
            this.panel1.TabIndex = 23;
            // 
            // lblMotivasyonSozu
            // 
            this.lblMotivasyonSozu.Appearance.Font = new System.Drawing.Font("Tahoma", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMotivasyonSozu.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMotivasyonSozu.Appearance.Options.UseFont = true;
            this.lblMotivasyonSozu.Appearance.Options.UseForeColor = true;
            this.lblMotivasyonSozu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMotivasyonSozu.Location = new System.Drawing.Point(0, 0);
            this.lblMotivasyonSozu.Name = "lblMotivasyonSozu";
            this.lblMotivasyonSozu.Size = new System.Drawing.Size(1653, 574);
            this.lblMotivasyonSozu.TabIndex = 18;
            // 
            // MotivasyonSozleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitnessCenter.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1904, 871);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnYeniSöz);
            this.Controls.Add(this.labelControl1);
            this.Name = "MotivasyonSozleri";
            this.Text = "MotivasyonSozleri";
            this.Load += new System.EventHandler(this.MotivasyonSozleri_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnYeniSöz;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblMotivasyonSozu;
    }
}