namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FCetakStokBarang
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
            this.crystalReportStokBrg = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportStokBrg
            // 
            this.crystalReportStokBrg.ActiveViewIndex = -1;
            this.crystalReportStokBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportStokBrg.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportStokBrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportStokBrg.Location = new System.Drawing.Point(0, 0);
            this.crystalReportStokBrg.Name = "crystalReportStokBrg";
            this.crystalReportStokBrg.Size = new System.Drawing.Size(548, 315);
            this.crystalReportStokBrg.TabIndex = 0;
            // 
            // FCetakStokBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 315);
            this.Controls.Add(this.crystalReportStokBrg);
            this.Name = "FCetakStokBarang";
            this.Text = "Cetak Stok Barang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FCetakStokBarang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportStokBrg;
    }
}