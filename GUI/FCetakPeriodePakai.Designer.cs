namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FCetakPeriodePakai
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
            this.reportPeriodePakai = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportPeriodePakai
            // 
            this.reportPeriodePakai.ActiveViewIndex = -1;
            this.reportPeriodePakai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportPeriodePakai.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportPeriodePakai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPeriodePakai.Location = new System.Drawing.Point(0, 0);
            this.reportPeriodePakai.Name = "reportPeriodePakai";
            this.reportPeriodePakai.Size = new System.Drawing.Size(651, 368);
            this.reportPeriodePakai.TabIndex = 0;
            // 
            // FCetakPeriodePakai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 368);
            this.Controls.Add(this.reportPeriodePakai);
            this.Name = "FCetakPeriodePakai";
            this.Text = "Cetak Pemakaian Barang Per Periode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FCetakPeriodePakai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportPeriodePakai;
    }
}