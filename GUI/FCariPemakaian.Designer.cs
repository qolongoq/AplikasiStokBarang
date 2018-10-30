namespace Project_PemantauanBarangDisbertam.GUI
{
    partial class FCariPemakaian
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridPemakaian = new System.Windows.Forms.DataGridView();
            this.txtCariPemakaian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPemakaian)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridPemakaian);
            this.groupBox1.Controls.Add(this.txtCariPemakaian);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".:: Data Pemakaian ::.";
            // 
            // dataGridPemakaian
            // 
            this.dataGridPemakaian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPemakaian.Location = new System.Drawing.Point(24, 77);
            this.dataGridPemakaian.Name = "dataGridPemakaian";
            this.dataGridPemakaian.Size = new System.Drawing.Size(439, 189);
            this.dataGridPemakaian.TabIndex = 2;
            this.dataGridPemakaian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPemakaian_CellClick);
            // 
            // txtCariPemakaian
            // 
            this.txtCariPemakaian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariPemakaian.Location = new System.Drawing.Point(22, 47);
            this.txtCariPemakaian.Name = "txtCariPemakaian";
            this.txtCariPemakaian.Size = new System.Drawing.Size(441, 22);
            this.txtCariPemakaian.TabIndex = 1;
            this.txtCariPemakaian.TextChanged += new System.EventHandler(this.txtCariPemakaian_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan No Pemakaian :";
            // 
            // FCariPemakaian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 296);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCariPemakaian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCariPemakaian";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPemakaian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridPemakaian;
        private System.Windows.Forms.TextBox txtCariPemakaian;
        private System.Windows.Forms.Label label1;
    }
}