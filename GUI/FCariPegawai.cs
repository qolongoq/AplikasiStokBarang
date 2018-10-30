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
    public partial class FCariPegawai : Form
    {
        //2.
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idpegawai, namapegawai = "";

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //4.
        void refresh_pegawai()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from tbl_pegawai", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_pegawai");
                dataGridPegawai.DataSource = ds;
                dataGridPegawai.DataMember = "tbl_pegawai";
                dataGridPegawai.Refresh();
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


        public FCariPegawai()
        {
            InitializeComponent();
            //5.
            txtCariPegawai.Clear();
            refresh_pegawai();
        }


        private void txtCariPegawai_TextChanged(object sender, EventArgs e)
        {
            //6.
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_pegawai where NamaPegawai like '%" + txtCariPegawai.Text + "%' or IDPegawai like '%" + txtCariPegawai.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_pegawai");
            dataGridPegawai.DataSource = ds;
            dataGridPegawai.DataMember = "tbl_pegawai";
            dataGridPegawai.Refresh();
            conn.Close();
        }

        private void dataGridPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //7.
            try
            {
                DataGridViewRow row = this.dataGridPegawai.Rows[e.RowIndex];
                idpegawai = row.Cells["IDPegawai"].Value.ToString();
                namapegawai = row.Cells["NamaPegawai"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }


        //8.
        public String ambil_id_pegawai
        {
            get
            {
                return idpegawai;
            }
        }

        //9.
        public String ambil_nama_pegawai
        {
            get
            {
                return namapegawai;
            }
        }

    }
}
