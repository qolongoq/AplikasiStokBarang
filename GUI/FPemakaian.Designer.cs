namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FPemakaian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPemakaian));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnCariBarang = new System.Windows.Forms.Button();
            this.txtJumlahPakai = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCariPegawai = new System.Windows.Forms.Button();
            this.txtNamaPegawai = new System.Windows.Forms.TextBox();
            this.txtIDPegawai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridPemakaian = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTanggalPakai = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoPemakaian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPemakaian)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.btnBaru);
            this.panel1.Location = new System.Drawing.Point(16, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 77);
            this.panel1.TabIndex = 15;
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
            this.btnSimpan.Size = new System.Drawing.Size(97, 39);
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
            this.btnBaru.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBaru.Size = new System.Drawing.Size(92, 39);
            this.btnBaru.TabIndex = 0;
            this.btnBaru.Text = "Baru";
            this.btnBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtKeterangan);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnKurang);
            this.groupBox4.Controls.Add(this.btnTambah);
            this.groupBox4.Controls.Add(this.btnCariBarang);
            this.groupBox4.Controls.Add(this.txtJumlahPakai);
            this.groupBox4.Controls.Add(this.txtNamaBarang);
            this.groupBox4.Controls.Add(this.txtKodeBarang);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 232);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Barang";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeterangan.Location = new System.Drawing.Point(124, 115);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(278, 65);
            this.txtKeterangan.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Keterangan";
            // 
            // btnKurang
            // 
            this.btnKurang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurang.Image = global::Project_PemantauanBarangDisbertam.Properties.Resources.cancel32;
            this.btnKurang.Location = new System.Drawing.Point(332, 186);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(70, 40);
            this.btnKurang.TabIndex = 10;
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Image = global::Project_PemantauanBarangDisbertam.Properties.Resources.add32;
            this.btnTambah.Location = new System.Drawing.Point(251, 186);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 40);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnCariBarang
            // 
            this.btnCariBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCariBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariBarang.Image = global::Project_PemantauanBarangDisbertam.Properties.Resources.search16;
            this.btnCariBarang.Location = new System.Drawing.Point(254, 24);
            this.btnCariBarang.Name = "btnCariBarang";
            this.btnCariBarang.Size = new System.Drawing.Size(39, 25);
            this.btnCariBarang.TabIndex = 8;
            this.btnCariBarang.UseVisualStyleBackColor = true;
            this.btnCariBarang.Click += new System.EventHandler(this.btnCariBarang_Click);
            // 
            // txtJumlahPakai
            // 
            this.txtJumlahPakai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahPakai.Location = new System.Drawing.Point(124, 85);
            this.txtJumlahPakai.Name = "txtJumlahPakai";
            this.txtJumlahPakai.Size = new System.Drawing.Size(100, 22);
            this.txtJumlahPakai.TabIndex = 7;
            this.txtJumlahPakai.Text = "txtJumlahPakai";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBarang.Location = new System.Drawing.Point(124, 55);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.ReadOnly = true;
            this.txtNamaBarang.Size = new System.Drawing.Size(278, 22);
            this.txtNamaBarang.TabIndex = 5;
            this.txtNamaBarang.Text = "txtNamaBarang";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeBarang.Location = new System.Drawing.Point(124, 25);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(124, 22);
            this.txtKodeBarang.TabIndex = 4;
            this.txtKodeBarang.Text = "txtKodeBarang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Jumlah Pakai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kode Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCariPegawai);
            this.groupBox3.Controls.Add(this.txtNamaPegawai);
            this.groupBox3.Controls.Add(this.txtIDPegawai);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 89);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Pegawai";
            // 
            // btnCariPegawai
            // 
            this.btnCariPegawai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCariPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariPegawai.Image = global::Project_PemantauanBarangDisbertam.Properties.Resources.search16;
            this.btnCariPegawai.Location = new System.Drawing.Point(255, 22);
            this.btnCariPegawai.Name = "btnCariPegawai";
            this.btnCariPegawai.Size = new System.Drawing.Size(39, 25);
            this.btnCariPegawai.TabIndex = 4;
            this.btnCariPegawai.UseVisualStyleBackColor = true;
            this.btnCariPegawai.Click += new System.EventHandler(this.btnCariPegawai_Click);
            // 
            // txtNamaPegawai
            // 
            this.txtNamaPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPegawai.Location = new System.Drawing.Point(125, 51);
            this.txtNamaPegawai.Name = "txtNamaPegawai";
            this.txtNamaPegawai.ReadOnly = true;
            this.txtNamaPegawai.Size = new System.Drawing.Size(278, 22);
            this.txtNamaPegawai.TabIndex = 3;
            this.txtNamaPegawai.Text = "txtNamaPegawai";
            // 
            // txtIDPegawai
            // 
            this.txtIDPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPegawai.Location = new System.Drawing.Point(125, 23);
            this.txtIDPegawai.Name = "txtIDPegawai";
            this.txtIDPegawai.Size = new System.Drawing.Size(124, 22);
            this.txtIDPegawai.TabIndex = 2;
            this.txtIDPegawai.Text = "txtIDPegawai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama Pegawai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Pegawai";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridPemakaian);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(429, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 514);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".:: Detail Pemakaian ::.";
            // 
            // dataGridPemakaian
            // 
            this.dataGridPemakaian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPemakaian.Location = new System.Drawing.Point(9, 19);
            this.dataGridPemakaian.Name = "dataGridPemakaian";
            this.dataGridPemakaian.Size = new System.Drawing.Size(717, 489);
            this.dataGridPemakaian.TabIndex = 0;
            this.dataGridPemakaian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPemakaian_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTanggalPakai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNoPemakaian);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pemakaian";
            // 
            // dtpTanggalPakai
            // 
            this.dtpTanggalPakai.CustomFormat = "MM/dd/yyyy";
            this.dtpTanggalPakai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalPakai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalPakai.Location = new System.Drawing.Point(125, 52);
            this.dtpTanggalPakai.Name = "dtpTanggalPakai";
            this.dtpTanggalPakai.Size = new System.Drawing.Size(124, 22);
            this.dtpTanggalPakai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal";
            // 
            // txtNoPemakaian
            // 
            this.txtNoPemakaian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPemakaian.Location = new System.Drawing.Point(125, 26);
            this.txtNoPemakaian.Name = "txtNoPemakaian";
            this.txtNoPemakaian.ReadOnly = true;
            this.txtNoPemakaian.Size = new System.Drawing.Size(124, 22);
            this.txtNoPemakaian.TabIndex = 1;
            this.txtNoPemakaian.Text = "txtNoPemakaian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Pemakaian";
            // 
            // FPemakaian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPemakaian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pemakaian Barang";
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPemakaian)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnCariBarang;
        private System.Windows.Forms.TextBox txtJumlahPakai;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCariPegawai;
        private System.Windows.Forms.TextBox txtNamaPegawai;
        private System.Windows.Forms.TextBox txtIDPegawai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridPemakaian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTanggalPakai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNoPemakaian;
    }
}