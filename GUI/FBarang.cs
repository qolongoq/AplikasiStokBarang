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
    public partial class FBarang : Form
    {
        //2.
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //4.
        void BERSIH()
        {
            txtKodeBarang.Clear();
            txtNamaBarang.Clear();
            txtStok.Clear();
            txtCariBarang.Clear();
        }

        //5.
        void ATUR_TOMBOL(Boolean status)
        {
            btnUbah.Enabled = status;
            btnHapus.Enabled = status;
        }

        //6.
        void Refresh_Barang()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_barang", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_barang");
                listBarang.DataSource = ds;
                listBarang.DataMember = "tbl_barang";
                listBarang.Refresh();
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

        private void auto_number()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeBarang from tbl_barang where KodeBarang in(select max(KodeBarang) from tbl_barang) order by KodeBarang desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "B" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "B0001";
            }
            rd.Close();
            txtKodeBarang.Text = urut;
            conn.Close();
        }


        public FBarang()
        {
            InitializeComponent();

            //7.
            BERSIH();
            ATUR_TOMBOL(false);
            Refresh_Barang();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            //8.
            BERSIH();
            auto_number();
            txtNamaBarang.Focus();
            ATUR_TOMBOL(false);
            btnSimpan.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //9.
            if (txtKodeBarang.Text.Trim() == "" || txtNamaBarang.Text.Trim() == "" || txtStok.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Kembali", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("INSERT INTO tbl_barang values('" + txtKodeBarang.Text + "','" + txtNamaBarang.Text + "','" + txtStok.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BERSIH();
                    Refresh_Barang();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void listBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //10.
            try
            {
                btnSimpan.Enabled = false;
                ATUR_TOMBOL(true);
                DataGridViewRow row = this.listBarang.Rows[e.RowIndex];
                txtKodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
                txtNamaBarang.Text = row.Cells["NamaBarang"].Value.ToString();
                txtStok.Text = row.Cells["Stok"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            //11.
            if (txtKodeBarang.Text.Trim() == "" || txtNamaBarang.Text.Trim() == "" || txtStok.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Kembali", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("UPDATE tbl_barang set NamaBarang = '" + txtNamaBarang.Text + "', Stok = '" + txtStok.Text + "' where KodeBarang = '" + txtKodeBarang.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BERSIH();
                    Refresh_Barang();
                    ATUR_TOMBOL(false);
                    btnSimpan.Enabled = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            //12.
            Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //13.
            if (MessageBox.Show("Ingin Menghapus Data Barang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("delete from tbl_barang where KodeBarang = '" + txtKodeBarang.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Barang Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BERSIH();
                Refresh_Barang();
                ATUR_TOMBOL(false);
                btnSimpan.Enabled = true;
            }
        }

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            //14.
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_barang where NamaBarang Like '%" + txtCariBarang.Text + "%' or KodeBarang = '" + txtCariBarang.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_barang");
            listBarang.DataSource = ds;
            listBarang.DataMember = "tbl_barang";
            listBarang.Refresh();
            conn.Close();
        }
    }
}
