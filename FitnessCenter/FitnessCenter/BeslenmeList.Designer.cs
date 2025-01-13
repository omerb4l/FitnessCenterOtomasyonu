namespace FitnessCenter
{
    partial class BeslenmeList
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
            this.pdfBeslenmeList = new DevExpress.XtraPdfViewer.PdfViewer();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // pdfBeslenmeList
            // 
            this.pdfBeslenmeList.Location = new System.Drawing.Point(224, 87);
            this.pdfBeslenmeList.Name = "pdfBeslenmeList";
            this.pdfBeslenmeList.ShowPrintStatusDialog = false;
            this.pdfBeslenmeList.Size = new System.Drawing.Size(1456, 697);
            this.pdfBeslenmeList.TabIndex = 8;
            // 
            // btnGeri
            // 
            this.btnGeri.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGeri.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGeri.Appearance.Options.UseBackColor = true;
            this.btnGeri.Appearance.Options.UseFont = true;
            this.btnGeri.Appearance.Options.UseForeColor = true;
            this.btnGeri.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnGeri.Location = new System.Drawing.Point(52, 724);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(142, 60);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // BeslenmeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitnessCenter.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1904, 871);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.pdfBeslenmeList);
            this.Name = "BeslenmeList";
            this.Text = "BeslenmeList";
            this.Load += new System.EventHandler(this.BeslenmeList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer pdfBeslenmeList;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
    }
}