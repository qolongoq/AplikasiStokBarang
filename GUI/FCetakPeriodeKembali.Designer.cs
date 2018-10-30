namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FCetakPeriodeKembali
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
            this.reportPeriodeKembali = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportPeriodeKembali
            // 
            this.reportPeriodeKembali.ActiveViewIndex = -1;
            this.reportPeriodeKembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportPeriodeKembali.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportPeriodeKembali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPeriodeKembali.Location = new System.Drawing.Point(0, 0);
            this.reportPeriodeKembali.Name = "reportPeriodeKembali";
            this.reportPeriodeKembali.Size = new System.Drawing.Size(577, 290);
            this.reportPeriodeKembali.TabIndex = 0;
            // 
            // FCetakPeriodeKembali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 290);
            this.Controls.Add(this.reportPeriodeKembali);
            this.Name = "FCetakPeriodeKembali";
            this.Text = "Cetak Pengembalian Barang Per Periode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FCetakPeriodeKembali_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportPeriodeKembali;
    }
}