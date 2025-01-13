namespace FitnessCenter
{
    partial class KullanicilariGoruntule
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
            this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(224, 42);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(1573, 737);
            this.dataGridViewKullanicilar.TabIndex = 0;
            // 
            // btnGeri
            // 
            this.btnGeri.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnGeri.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGeri.Appearance.Options.UseBackColor = true;
            this.btnGeri.Appearance.Options.UseFont = true;
            this.btnGeri.Appearance.Options.UseForeColor = true;
            this.btnGeri.Location = new System.Drawing.Point(45, 400);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(135, 53);
            this.btnGeri.TabIndex = 50;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // KullanicilariGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitnessCenter.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1904, 871);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dataGridViewKullanicilar);
            this.Name = "KullanicilariGoruntule";
            this.Text = "KullanicilariGoruntule";
            this.Load += new System.EventHandler(this.KullanicilariGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
    }
}