namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FPengembalian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPengembalian));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtJumlahPakai = new System.Windows.Forms.TextBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCariPemakaian = new System.Windows.Forms.Button();
            this.txtNoPemakaian = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridPengembalian = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTanggalKembali = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoPengembalian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJumlahKembali = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPengembalian)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.btnBaru);
            this.panel1.Location = new System.Drawing.Point(16, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 77);
            this.panel1.TabIndex = 20;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.Red;
            this.btnKeluar.Image = global::Project_PemantauanBarangDisbertam.Properties.Resources.exit32;
            this.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.Location = new System.Drawing.Point(313, 16);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(91, 39);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Image")));
            this.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.Location = new System.Drawing.Point(123, 16);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 39);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBaru
            // 
            this.btnBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaru.Image = ((System.Drawing.Image)(resources.GetObject("btnBaru.Image")));
            this.btnBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaru.Location = new System.Drawing.Point(15, 16);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(90, 39);
            this.btnBaru.TabIndex = 0;
            this.btnBaru.Text = "Baru";
            this.btnBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurang.Image = global::Project_PemantauanBarangDisbertam.Properties.Resources.cancel32;
            this.btnKurang.Location = new System.Drawing.Point(348, 270);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(70, 44);
            this.btnKurang.TabIndex = 10;
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Image = global::Project_PemantauanBarangDisbertam.Properties.Resources.add32;
            this.btnTambah.Location = new System.Drawing.Point(267, 270);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 44);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtJumlahPakai
            // 
            this.txtJumlahPakai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahPakai.Location = new System.Drawing.Point(138, 85);
            this.txtJumlahPakai.Name = "txtJumlahPakai";
            this.txtJumlahPakai.ReadOnly = true;
            this.txtJumlahPakai.Size = new System.Drawing.Size(100, 22);
            this.txtJumlahPakai.TabIndex = 7;
            this.txtJumlahPakai.Text = "txtJumlahPakai";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeBarang.Location = new System.Drawing.Point(138, 54);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.ReadOnly = true;
            this.txtKodeBarang.Size = new System.Drawing.Size(268, 22);
            this.txtKodeBarang.TabIndex = 5;
            this.txtKodeBarang.Text = "txtKodeBarang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Jumlah Pakai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kode Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCariPemakaian);
            this.groupBox3.Controls.Add(this.txtNoPemakaian);
            this.groupBox3.Controls.Add(this.txtJumlahPakai);
            this.groupBox3.Controls.Add(this.txtKodeBarang);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 121);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Pemakaian";
            // 
            // btnCariPemakaian
            // 
            this.btnCariPemakaian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariPemakaian.Image = global::Project_PemantauanBarangDisbertam.Properties.Resources.search16;
            this.btnCariPemakaian.Location = new System.Drawing.Point(268, 21);
            this.btnCariPemakaian.Name = "btnCariPemakaian";
            this.btnCariPemakaian.Size = new System.Drawing.Size(37, 25);
            this.btnCariPemakaian.TabIndex = 4;
            this.btnCariPemakaian.UseVisualStyleBackColor = true;
            this.btnCariPemakaian.Click += new System.EventHandler(this.btnCariPemakaian_Click);
            // 
            // txtNoPemakaian
            // 
            this.txtNoPemakaian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPemakaian.Location = new System.Drawing.Point(138, 23);
            this.txtNoPemakaian.Name = "txtNoPemakaian";
            this.txtNoPemakaian.Size = new System.Drawing.Size(124, 22);
            this.txtNoPemakaian.TabIndex = 2;
            this.txtNoPemakaian.Text = "txtNoPemakaian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "No Pemakaian";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridPengembalian);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(429, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 385);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".:: Detail Pengembalian ::.";
            // 
            // dataGridPengembalian
            // 
            this.dataGridPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPengembalian.Location = new System.Drawing.Point(9, 19);
            this.dataGridPengembalian.Name = "dataGridPengembalian";
            this.dataGridPengembalian.Size = new System.Drawing.Size(628, 356);
            this.dataGridPengembalian.TabIndex = 0;
            this.dataGridPengembalian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPengembalian_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTanggalKembali);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNoPengembalian);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 91);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pengembalian";
            // 
            // dtpTanggalKembali
            // 
            this.dtpTanggalKembali.CustomFormat = "MM/dd/yyyy";
            this.dtpTanggalKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalKembali.Location = new System.Drawing.Point(138, 54);
            this.dtpTanggalKembali.Name = "dtpTanggalKembali";
            this.dtpTanggalKembali.Size = new System.Drawing.Size(124, 22);
            this.dtpTanggalKembali.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Kembali";
            // 
            // txtNoPengembalian
            // 
            this.txtNoPengembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPengembalian.Location = new System.Drawing.Point(138, 26);
            this.txtNoPengembalian.Name = "txtNoPengembalian";
            this.txtNoPengembalian.ReadOnly = true;
            this.txtNoPengembalian.Size = new System.Drawing.Size(124, 22);
            this.txtNoPengembalian.TabIndex = 1;
            this.txtNoPengembalian.Text = "txtNoPengembalian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Pengembalian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Jumlah Kembali";
            // 
            // txtJumlahKembali
            // 
            this.txtJumlahKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahKembali.Location = new System.Drawing.Point(150, 232);
            this.txtJumlahKembali.Name = "txtJumlahKembali";
            this.txtJumlahKembali.Size = new System.Drawing.Size(100, 22);
            this.txtJumlahKembali.TabIndex = 22;
            this.txtJumlahKembali.Text = "txtJumlahKembali";
            // 
            // FPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 403);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.txtJumlahKembali);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPengembalian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengembalian Barang";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPengembalian)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtJumlahPakai;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCariPemakaian;
        private System.Windows.Forms.TextBox txtNoPemakaian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridPengembalian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTanggalKembali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJumlahKembali;
        public System.Windows.Forms.TextBox txtNoPengembalian;
    }
}