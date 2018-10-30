namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FCetakPengembalian
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
            this.crystalReportKembali = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportKembali
            // 
            this.crystalReportKembali.ActiveViewIndex = -1;
            this.crystalReportKembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportKembali.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportKembali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportKembali.Location = new System.Drawing.Point(0, 0);
            this.crystalReportKembali.Name = "crystalReportKembali";
            this.crystalReportKembali.Size = new System.Drawing.Size(646, 480);
            this.crystalReportKembali.TabIndex = 0;
            // 
            // FCetakPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 480);
            this.Controls.Add(this.crystalReportKembali);
            this.Name = "FCetakPengembalian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cetak Laporan Pengembalian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FCetakPengembalian_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportKembali;
    }
}