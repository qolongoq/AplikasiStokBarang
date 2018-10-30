namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FLaporan
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
            System.Windows.Forms.GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLaporan));
            this.rbStokBrg = new System.Windows.Forms.RadioButton();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSelesaiPakai = new System.Windows.Forms.DateTimePicker();
            this.dtpAwalPakai = new System.Windows.Forms.DateTimePicker();
            this.rbPeriodePakai = new System.Windows.Forms.RadioButton();
            this.dtpPerTanggalPakai = new System.Windows.Forms.DateTimePicker();
            this.rbPerTanggalPakai = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSelesaiKembali = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAwalKembali = new System.Windows.Forms.DateTimePicker();
            this.dtpPerTanggalKembali = new System.Windows.Forms.DateTimePicker();
            this.rbPeriodeKembali = new System.Windows.Forms.RadioButton();
            this.rbPerTanggalKembali = new System.Windows.Forms.RadioButton();
            this.btnKeluar = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.rbStokBrg);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.Location = new System.Drawing.Point(23, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(392, 53);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cetak Stok Barang";
            // 
            // rbStokBrg
            // 
            this.rbStokBrg.AutoSize = true;
            this.rbStokBrg.Location = new System.Drawing.Point(6, 23);
            this.rbStokBrg.Name = "rbStokBrg";
            this.rbStokBrg.Size = new System.Drawing.Size(100, 20);
            this.rbStokBrg.TabIndex = 0;
            this.rbStokBrg.TabStop = true;
            this.rbStokBrg.Text = "Stok Barang";
            this.rbStokBrg.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.Image")));
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(222, 326);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(95, 33);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "s/d";
            // 
            // dtpSelesaiPakai
            // 
            this.dtpSelesaiPakai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSelesaiPakai.Location = new System.Drawing.Point(258, 58);
            this.dtpSelesaiPakai.Name = "dtpSelesaiPakai";
            this.dtpSelesaiPakai.Size = new System.Drawing.Size(110, 22);
            this.dtpSelesaiPakai.TabIndex = 7;
            // 
            // dtpAwalPakai
            // 
            this.dtpAwalPakai.CustomFormat = "";
            this.dtpAwalPakai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAwalPakai.Location = new System.Drawing.Point(115, 58);
            this.dtpAwalPakai.Name = "dtpAwalPakai";
            this.dtpAwalPakai.Size = new System.Drawing.Size(108, 22);
            this.dtpAwalPakai.TabIndex = 6;
            // 
            // rbPeriodePakai
            // 
            this.rbPeriodePakai.AutoSize = true;
            this.rbPeriodePakai.Location = new System.Drawing.Point(6, 59);
            this.rbPeriodePakai.Name = "rbPeriodePakai";
            this.rbPeriodePakai.Size = new System.Drawing.Size(98, 20);
            this.rbPeriodePakai.TabIndex = 11;
            this.rbPeriodePakai.TabStop = true;
            this.rbPeriodePakai.Text = "Per Periode";
            this.rbPeriodePakai.UseVisualStyleBackColor = true;
            // 
            // dtpPerTanggalPakai
            // 
            this.dtpPerTanggalPakai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPerTanggalPakai.Location = new System.Drawing.Point(115, 25);
            this.dtpPerTanggalPakai.Name = "dtpPerTanggalPakai";
            this.dtpPerTanggalPakai.Size = new System.Drawing.Size(108, 22);
            this.dtpPerTanggalPakai.TabIndex = 12;
            // 
            // rbPerTanggalPakai
            // 
            this.rbPerTanggalPakai.AutoSize = true;
            this.rbPerTanggalPakai.Location = new System.Drawing.Point(6, 27);
            this.rbPerTanggalPakai.Name = "rbPerTanggalPakai";
            this.rbPerTanggalPakai.Size = new System.Drawing.Size(101, 20);
            this.rbPerTanggalPakai.TabIndex = 13;
            this.rbPerTanggalPakai.TabStop = true;
            this.rbPerTanggalPakai.Text = "Per Tanggal";
            this.rbPerTanggalPakai.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbPerTanggalPakai);
            this.groupBox1.Controls.Add(this.dtpPerTanggalPakai);
            this.groupBox1.Controls.Add(this.rbPeriodePakai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpSelesaiPakai);
            this.groupBox1.Controls.Add(this.dtpAwalPakai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 111);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cetak Pemakaian Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(113, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bulan/Tanggal/Tahun";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtpSelesaiKembali);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpAwalKembali);
            this.groupBox3.Controls.Add(this.dtpPerTanggalKembali);
            this.groupBox3.Controls.Add(this.rbPeriodeKembali);
            this.groupBox3.Controls.Add(this.rbPerTanggalKembali);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 113);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cetak Pengembalian Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(113, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Bulan/Tanggal/Tahun";
            // 
            // dtpSelesaiKembali
            // 
            this.dtpSelesaiKembali.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSelesaiKembali.Location = new System.Drawing.Point(258, 60);
            this.dtpSelesaiKembali.Name = "dtpSelesaiKembali";
            this.dtpSelesaiKembali.Size = new System.Drawing.Size(108, 22);
            this.dtpSelesaiKembali.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "s/d";
            // 
            // dtpAwalKembali
            // 
            this.dtpAwalKembali.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAwalKembali.Location = new System.Drawing.Point(115, 60);
            this.dtpAwalKembali.Name = "dtpAwalKembali";
            this.dtpAwalKembali.Size = new System.Drawing.Size(108, 22);
            this.dtpAwalKembali.TabIndex = 3;
            // 
            // dtpPerTanggalKembali
            // 
            this.dtpPerTanggalKembali.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPerTanggalKembali.Location = new System.Drawing.Point(115, 25);
            this.dtpPerTanggalKembali.Name = "dtpPerTanggalKembali";
            this.dtpPerTanggalKembali.Size = new System.Drawing.Size(108, 22);
            this.dtpPerTanggalKembali.TabIndex = 2;
            // 
            // rbPeriodeKembali
            // 
            this.rbPeriodeKembali.AutoSize = true;
            this.rbPeriodeKembali.Location = new System.Drawing.Point(6, 62);
            this.rbPeriodeKembali.Name = "rbPeriodeKembali";
            this.rbPeriodeKembali.Size = new System.Drawing.Size(98, 20);
            this.rbPeriodeKembali.TabIndex = 1;
            this.rbPeriodeKembali.Text = "Per Periode";
            this.rbPeriodeKembali.UseVisualStyleBackColor = true;
            // 
            // rbPerTanggalKembali
            // 
            this.rbPerTanggalKembali.AutoSize = true;
            this.rbPerTanggalKembali.Location = new System.Drawing.Point(6, 28);
            this.rbPerTanggalKembali.Name = "rbPerTanggalKembali";
            this.rbPerTanggalKembali.Size = new System.Drawing.Size(101, 20);
            this.rbPerTanggalKembali.TabIndex = 0;
            this.rbPerTanggalKembali.Text = "Per Tanggal";
            this.rbPerTanggalKembali.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.Red;
            this.btnKeluar.Image = global::Project_PemantauanBarangDisbertam.Properties.Resources.exit32;
            this.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.Location = new System.Drawing.Point(323, 326);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(91, 33);
            this.btnKeluar.TabIndex = 17;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 372);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cetak Laporan";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpSelesaiPakai;
        public System.Windows.Forms.DateTimePicker dtpAwalPakai;
        private System.Windows.Forms.RadioButton rbPeriodePakai;
        private System.Windows.Forms.RadioButton rbPerTanggalPakai;
        public System.Windows.Forms.DateTimePicker dtpPerTanggalPakai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStokBrg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPeriodeKembali;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpAwalKembali;
        public System.Windows.Forms.DateTimePicker dtpPerTanggalKembali;
        public System.Windows.Forms.DateTimePicker dtpSelesaiKembali;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.RadioButton rbPerTanggalKembali;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}