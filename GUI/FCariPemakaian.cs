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
    public partial class FCariPemakaian : Form
    {
        //2.
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string nopakai, kodebrg, jmlpakai = "";

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //4.
        void refresh_pemakaian()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from tbl_detail_pemakaian", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_detail_pemakaian");
                dataGridPemakaian.DataSource = ds;
                dataGridPemakaian.DataMember = "tbl_detail_pemakaian";
                dataGridPemakaian.Refresh();
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


        public FCariPemakaian()
        {
            InitializeComponent();
            //5.
            refresh_pemakaian();
        }

        private void dataGridPemakaian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //7.
            try
            {
                DataGridViewRow row = this.dataGridPemakaian.Rows[e.RowIndex];
                nopakai = row.Cells["NoPemakaian"].Value.ToString();
                kodebrg = row.Cells["KodeBarang"].Value.ToString();
                jmlpakai = row.Cells["JumlahPakai"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }


        //8.
        public String ambil_nopakai
        {
            get
            {
                return nopakai;
            }
        }

        //9.
        public String ambil_kodebrg
        {
            get
            {
                return kodebrg;
            }
        }

        //10.
        public String ambil_jmlpakai
        {
            get
            {
                return jmlpakai;
            }
        }

        private void txtCariPemakaian_TextChanged(object sender, EventArgs e)
        {
            //6.
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_pemakaian where NoPemakaian like '%" + txtCariPemakaian.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "NoPemakaian");
            dataGridPemakaian.DataSource = ds;
            dataGridPemakaian.DataMember = "NoPemakaian";
            dataGridPemakaian.Refresh();
            conn.Close();
        }

    }
}
