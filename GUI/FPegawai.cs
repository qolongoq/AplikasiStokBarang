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
    public partial class FPegawai : Form
    {

        //2.
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //4.
        void BERSIH()
        {
            txtIDPegawai.Clear();
            txtNamaPegawai.Clear();
            txtJabatan.Clear();
            txtAlamat.Clear();
            txtNoTelp.Clear();
            txtCariPegawai.Clear();
        }

        //5.
        void ATUR_TOMBOL(Boolean status)
        {
            btnUbah.Enabled = status;
            btnHapus.Enabled = status;
        }

        //6.
        void Refresh_Pegawai()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_pegawai", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_pegawai");
                listPegawai.DataSource = ds;
                listPegawai.DataMember = "tbl_pegawai";
                listPegawai.Refresh();
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


        public FPegawai()
        {
            InitializeComponent();
            //7.
            BERSIH();
            ATUR_TOMBOL(false);
            Refresh_Pegawai();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            //8.
            BERSIH();
            txtIDPegawai.Focus();
            ATUR_TOMBOL(false);
            btnSimpan.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //9.
            if (txtIDPegawai.Text.Trim() == "" || txtNamaPegawai.Text.Trim() == "" || txtJabatan.Text.Trim() == "" || txtAlamat.Text.Trim() == "" || txtNoTelp.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Kembali", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("INSERT INTO tbl_pegawai values('" + txtIDPegawai.Text + "','" + txtNamaPegawai.Text + "','" + txtJabatan.Text + "','" + txtAlamat.Text + "','" + txtNoTelp.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BERSIH();
                    Refresh_Pegawai();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void listPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //10.
            try
            {
                btnSimpan.Enabled = false;
                ATUR_TOMBOL(true);
                DataGridViewRow row = this.listPegawai.Rows[e.RowIndex];
                txtIDPegawai.Text = row.Cells["IDPegawai"].Value.ToString();
                txtNamaPegawai.Text = row.Cells["NamaPegawai"].Value.ToString();
                txtJabatan.Text = row.Cells["Jabatan"].Value.ToString();
                txtAlamat.Text = row.Cells["Alamat"].Value.ToString();
                txtNoTelp.Text = row.Cells["NoTelp"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            //11.
            if (txtIDPegawai.Text.Trim() == "" || txtNamaPegawai.Text.Trim() == "" || txtJabatan.Text.Trim() == "" || txtAlamat.Text.Trim() == "" || txtNoTelp.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Kembali", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("UPDATE tbl_pegawai set NamaPegawai = '" + txtNamaPegawai.Text + "', Jabatan = '" + txtJabatan.Text + "', Alamat = '" + txtAlamat.Text + "', NoTelp = '" + txtNoTelp.Text + "' where IDPegawai = '" + txtIDPegawai.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BERSIH();
                    Refresh_Pegawai();
                    ATUR_TOMBOL(false);
                    btnSimpan.Enabled = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //12.
            if (MessageBox.Show("Ingin Menghapus Data Pegawai?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("delete from tbl_pegawai where IDPegawai = '" + txtIDPegawai.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Pegawai Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BERSIH();
                Refresh_Pegawai();
                ATUR_TOMBOL(false);
                btnSimpan.Enabled = true;
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            //13.
            Close();
        }

        private void txtCariPegawai_TextChanged(object sender, EventArgs e)
        {
            //14.
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_pegawai where NamaPegawai Like '%" + txtCariPegawai.Text + "%' or IDPegawai = '" + txtCariPegawai.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_pegawai");
            listPegawai.DataSource = ds;
            listPegawai.DataMember = "tbl_pegawai";
            listPegawai.Refresh();
            conn.Close();
        }

    }
}
