namespace FitnessCenter
{
    partial class AntrenmanList
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
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.pdfAntrenmanList = new DevExpress.XtraPdfViewer.PdfViewer();
            this.SuspendLayout();
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
            this.btnGeri.Location = new System.Drawing.Point(47, 724);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(142, 60);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pdfAntrenmanList
            // 
            this.pdfAntrenmanList.Location = new System.Drawing.Point(224, 87);
            this.pdfAntrenmanList.Name = "pdfAntrenmanList";
            this.pdfAntrenmanList.ShowPrintStatusDialog = false;
            this.pdfAntrenmanList.Size = new System.Drawing.Size(1456, 697);
            this.pdfAntrenmanList.TabIndex = 7;
            // 
            // AntrenmanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitnessCenter.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1904, 871);
            this.Controls.Add(this.pdfAntrenmanList);
            this.Controls.Add(this.btnGeri);
            this.Name = "AntrenmanList";
            this.Text = "AntrenmanList";
            this.Load += new System.EventHandler(this.AntrenmanList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private DevExpress.XtraPdfViewer.PdfViewer pdfAntrenmanList;
    }
}