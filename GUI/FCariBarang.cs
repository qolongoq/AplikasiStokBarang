using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1.
using System.Data.SqlClient;

namespace Project_PemantauanBarangDisbertam.GUI
{
    public partial class FCariBarang : Form
    {
        //2.
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string kodebrg, namabrg = "";

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //4.
        void refresh_barang()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from tbl_barang", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_barang");
                dataGridBarang.DataSource = ds;
                dataGridBarang.DataMember = "tbl_barang";
                dataGridBarang.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }


        public FCariBarang()
        {
            InitializeComponent();
            //5.
            txtCariBarang.Clear();
            refresh_barang();
        }


        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            //6.
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_barang where NamaBarang like '%" + txtCariBarang.Text + "%' or KodeBarang like '%" + txtCariBarang.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_barang");
            dataGridBarang.DataSource = ds;
            dataGridBarang.DataMember = "tbl_barang";
            dataGridBarang.Refresh();
            conn.Close();
        }

        private void dataGridBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //7.
            try
            {
                DataGridViewRow row = this.dataGridBarang.Rows[e.RowIndex];
                kodebrg = row.Cells["KodeBarang"].Value.ToString();
                namabrg = row.Cells["NamaBarang"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }


        //8.
        public String ambil_kode_barang
        {
            get
            {
                return kodebrg;
            }
        }

        //9.
        public String ambil_nama_barang
        {
            get
            {
                return namabrg;
            }
        }

    }
}
