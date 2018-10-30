namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FMenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenuUtama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Master = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.pemakaianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanLaporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tool_Pegawai = new System.Windows.Forms.ToolStripButton();
            this.Tool_Barang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_Pemakaian = new System.Windows.Forms.ToolStripButton();
            this.Tool_Pengembalian = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_Keluar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Master,
            this.Menu_Transaksi,
            this.Menu_Laporan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(40, 20);
            this.Menu_File.Text = "&FILE";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Menu_Master
            // 
            this.Menu_Master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPegawaiToolStripMenuItem,
            this.dataBarangToolStripMenuItem});
            this.Menu_Master.Name = "Menu_Master";
            this.Menu_Master.Size = new System.Drawing.Size(96, 20);
            this.Menu_Master.Text = "&MASTER DATA";
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.dataPegawaiToolStripMenuItem.Text = "Pegawai";
            this.dataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.dataPegawaiToolStripMenuItem_Click);
            // 
            // dataBarangToolStripMenuItem
            // 
            this.dataBarangToolStripMenuItem.Name = "dataBarangToolStripMenuItem";
            this.dataBarangToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.dataBarangToolStripMenuItem.Text = "Barang";
            this.dataBarangToolStripMenuItem.Click += new System.EventHandler(this.dataBarangToolStripMenuItem_Click);
            // 
            // Menu_Transaksi
            // 
            this.Menu_Transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pemakaianToolStripMenuItem,
            this.pengembalianToolStripMenuItem});
            this.Menu_Transaksi.Name = "Menu_Transaksi";
            this.Menu_Transaksi.Size = new System.Drawing.Size(80, 20);
            this.Menu_Transaksi.Text = "&TRANSAKSI";
            // 
            // pemakaianToolStripMenuItem
            // 
            this.pemakaianToolStripMenuItem.Name = "pemakaianToolStripMenuItem";
            this.pemakaianToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pemakaianToolStripMenuItem.Text = "Pemakaian";
            this.pemakaianToolStripMenuItem.Click += new System.EventHandler(this.pemakaianToolStripMenuItem_Click);
            // 
            // pengembalianToolStripMenuItem
            // 
            this.pengembalianToolStripMenuItem.Name = "pengembalianToolStripMenuItem";
            this.pengembalianToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pengembalianToolStripMenuItem.Text = "Pengembalian";
            this.pengembalianToolStripMenuItem.Click += new System.EventHandler(this.pengembalianToolStripMenuItem_Click);
            // 
            // Menu_Laporan
            // 
            this.Menu_Laporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanLaporanToolStripMenuItem});
            this.Menu_Laporan.Name = "Menu_Laporan";
            this.Menu_Laporan.Size = new System.Drawing.Size(73, 20);
            this.Menu_Laporan.Text = "&LAPORAN";
            // 
            // laporanLaporanToolStripMenuItem
            // 
            this.laporanLaporanToolStripMenuItem.Name = "laporanLaporanToolStripMenuItem";
            this.laporanLaporanToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.laporanLaporanToolStripMenuItem.Text = "Cetak Laporan";
            this.laporanLaporanToolStripMenuItem.Click += new System.EventHandler(this.laporanLaporanToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Pegawai,
            this.Tool_Barang,
            this.toolStripSeparator2,
            this.Tool_Pemakaian,
            this.Tool_Pengembalian,
            this.toolStripSeparator3,
            this.Tool_Keluar});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(898, 47);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tool_Pegawai
            // 
            this.Tool_Pegawai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Pegawai.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Pegawai.Image")));
            this.Tool_Pegawai.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tool_Pegawai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Pegawai.Name = "Tool_Pegawai";
            this.Tool_Pegawai.Size = new System.Drawing.Size(36, 44);
            this.Tool_Pegawai.Text = "toolStripButton1";
            this.Tool_Pegawai.ToolTipText = "Menampilkan Form Pegawai ";
            this.Tool_Pegawai.Click += new System.EventHandler(this.Tool_Pegawai_Click);
            // 
            // Tool_Barang
            // 
            this.Tool_Barang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Barang.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Barang.Image")));
            this.Tool_Barang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tool_Barang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Barang.Name = "Tool_Barang";
            this.Tool_Barang.Size = new System.Drawing.Size(36, 44);
            this.Tool_Barang.Text = "toolStripButton1";
            this.Tool_Barang.ToolTipText = "Menampilkan Form Barang";
            this.Tool_Barang.Click += new System.EventHandler(this.Tool_Barang_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // Tool_Pemakaian
            // 
            this.Tool_Pemakaian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Pemakaian.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Pemakaian.Image")));
            this.Tool_Pemakaian.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tool_Pemakaian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Pemakaian.Name = "Tool_Pemakaian";
            this.Tool_Pemakaian.Size = new System.Drawing.Size(36, 44);
            this.Tool_Pemakaian.Text = "toolStripButton1";
            this.Tool_Pemakaian.ToolTipText = "Menampilkan Form Pemakaian";
            this.Tool_Pemakaian.Click += new System.EventHandler(this.Tool_Pemakaian_Click);
            // 
            // Tool_Pengembalian
            // 
            this.Tool_Pengembalian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Pengembalian.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Pengembalian.Image")));
            this.Tool_Pengembalian.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tool_Pengembalian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Pengembalian.Name = "Tool_Pengembalian";
            this.Tool_Pengembalian.Size = new System.Drawing.Size(36, 44);
            this.Tool_Pengembalian.Text = "toolStripButton2";
            this.Tool_Pengembalian.ToolTipText = "Menampilkan Form Pengembalian";
            this.Tool_Pengembalian.Click += new System.EventHandler(this.Tool_Pengembalian_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // Tool_Keluar
            // 
            this.Tool_Keluar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Keluar.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Keluar.Image")));
            this.Tool_Keluar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tool_Keluar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Keluar.Name = "Tool_Keluar";
            this.Tool_Keluar.Size = new System.Drawing.Size(36, 44);
            this.Tool_Keluar.Text = "toolStripButton1";
            this.Tool_Keluar.ToolTipText = "Keluar Aplikasi";
            this.Tool_Keluar.Click += new System.EventHandler(this.Tool_Keluar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(898, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel1.Text = "Created By : Myth Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "APLIKASI STOK BARANG PT. MENSA BINA SUKSES Kantor Cabang Bandar Lampung";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenuUtama";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Menu Utama Aplikasi Stok Barang PT. Mensa Binasukses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pemakaianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Tool_Keluar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Menu_Master;
        public System.Windows.Forms.ToolStripMenuItem Menu_Transaksi;
        public System.Windows.Forms.ToolStripButton Tool_Pegawai;
        public System.Windows.Forms.ToolStripButton Tool_Barang;
        public System.Windows.Forms.ToolStripButton Tool_Pemakaian;
        public System.Windows.Forms.ToolStripButton Tool_Pengembalian;
        private System.Windows.Forms.ToolStripMenuItem laporanLaporanToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripMenuItem Menu_Laporan;
    }
}