namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FCetakPemakaian
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
            this.crystalReportPakai = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportPakai
            // 
            this.crystalReportPakai.ActiveViewIndex = -1;
            this.crystalReportPakai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportPakai.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportPakai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportPakai.Location = new System.Drawing.Point(0, 0);
            this.crystalReportPakai.Name = "crystalReportPakai";
            this.crystalReportPakai.Size = new System.Drawing.Size(684, 501);
            this.crystalReportPakai.TabIndex = 0;
            // 
            // FCetakPemakaian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 501);
            this.Controls.Add(this.crystalReportPakai);
            this.Name = "FCetakPemakaian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cetak Laporan Pemakaian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FCetakPemakaian_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportPakai;
    }
}