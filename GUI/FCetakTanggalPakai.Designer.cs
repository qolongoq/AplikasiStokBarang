namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FCetakTanggalPakai
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
            this.reportTanggalPakai = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportTanggalPakai
            // 
            this.reportTanggalPakai.ActiveViewIndex = -1;
            this.reportTanggalPakai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportTanggalPakai.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportTanggalPakai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTanggalPakai.Location = new System.Drawing.Point(0, 0);
            this.reportTanggalPakai.Name = "reportTanggalPakai";
            this.reportTanggalPakai.Size = new System.Drawing.Size(595, 327);
            this.reportTanggalPakai.TabIndex = 0;
            // 
            // FCetakTanggalPakai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 327);
            this.Controls.Add(this.reportTanggalPakai);
            this.Name = "FCetakTanggalPakai";
            this.Text = "Cetak Pemakaian Barang Per Tanggal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FCetakTanggalPakai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportTanggalPakai;
    }
}