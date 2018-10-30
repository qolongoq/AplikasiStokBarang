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
    public partial class FPengembalian : Form
    {
        //Report.
        public static FPengembalian objPengembalian;

        //2.
        private SqlCommand cmd;
        private SqlDataReader rd;
        private DataSet ds;
        private SqlDataAdapter da;

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //4.
        private void bersih()
        {
            txtNoPengembalian.Text = "";
            dtpTanggalKembali.Value = DateTime.Now;
            txtNoPemakaian.Text = "";
            txtKodeBarang.Text = "";
            txtJumlahPakai.Text = "0";
            txtJumlahKembali.Text = "0";
        }

        //5.
        private void awal()
        {
            bersih();
            dataGridPengembalian.Enabled = false;
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pengembalian order by NoPengembalian desc", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pengembalian");
                    dataGridPengembalian.DataSource = ds;
                    dataGridPengembalian.DataMember = "tbl_pengembalian";
                    dataGridPengembalian.Refresh();
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
        }

        //6.
        private void auto_number()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select NoPengembalian from tbl_pengembalian where NoPengembalian in(select max(NoPengembalian) from tbl_pengembalian) order by NoPengembalian desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoPengembalian"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "K" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "K0001";
            }
            rd.Close();
            txtNoPengembalian.Text = urut;
            conn.Close();
        }

        //7.
        private void Simpan_MasterPengembalian()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tbl_pengembalian values ('" + txtNoPengembalian.Text + "','" + dtpTanggalKembali.Text + "','" + txtNoPemakaian.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //8.
        private void Simpan_DetailPengembalian()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tbl_detail_pengembalian values('" + txtNoPengembalian.Text + "','" + txtNoPemakaian.Text + "','" + txtKodeBarang.Text + "','" + txtJumlahPakai.Text + "','" + txtJumlahKembali.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //9.
        private void refresh_pengembalian()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from View_Detail_Pengembalian where NoPengembalian = '" + txtNoPengembalian.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "View_Detail_Pengembalian");
                    dataGridPengembalian.DataSource = ds;
                    dataGridPengembalian.DataMember = "View_Detail_Pengembalian";
                    dataGridPengembalian.Refresh();
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
        }

        //10.
        private void RefreshTransaksi()
        {
            refresh_pengembalian();
            txtNoPemakaian.Clear();
            txtKodeBarang.Clear();
            txtJumlahPakai.Text = "0";
            txtJumlahKembali.Text = "0";
            txtNoPemakaian.Focus();
        }


        public FPengembalian()
        {
            InitializeComponent();
            //Report.
            objPengembalian = this;

            //11.
            awal();
        }

        private void btnCariPemakaian_Click(object sender, EventArgs e)
        {
            //12.
            FCariPemakaian caripemakaian = new FCariPemakaian();
            caripemakaian.ShowDialog();
            txtNoPemakaian.Text = caripemakaian.ambil_nopakai;
            txtKodeBarang.Text = caripemakaian.ambil_kodebrg;
            txtJumlahPakai.Text = caripemakaian.ambil_jmlpakai;
            txtJumlahKembali.Focus();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            //14.
            awal();
            auto_number();
            dtpTanggalKembali.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            //15.
            dataGridPengembalian.Enabled = true;
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                if (txtNoPengembalian.Text.Trim() == "" || txtNoPemakaian.Text.Trim() == "" || txtJumlahKembali.Text.Trim() == "")
                {
                    MessageBox.Show("Data belum lengkap, lengkapi kembali", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pengembalian where NoPengembalian = '" + txtNoPengembalian.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        conn.Close();
                        conn.Open();
                        cmd = new SqlCommand("select * from tbl_detail_pengembalian where NoPengembalian = '" + txtNoPengembalian.Text + "' and KodeBarang = '" + txtKodeBarang.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Data Pemakaian " + txtNoPemakaian.Text + " Sudah Diinputkan, Harap Pilih Data Yang Lain", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Simpan_DetailPengembalian();
                        }
                    }
                    else
                    {
                        Simpan_MasterPengembalian();
                        Simpan_DetailPengembalian();
                    }
                    RefreshTransaksi();
                }
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            //16.
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("delete from tbl_detail_pengembalian where NoPengembalian = '" + txtNoPengembalian.Text + "' and NoPemakaian = '" + txtNoPemakaian.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("select * from tbl_detail_pengembalian where NoPengembalian = '" + txtNoPengembalian.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                RefreshTransaksi();
            }
        }

        private void dataGridPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //17.
            DataGridViewRow row = this.dataGridPengembalian.Rows[e.RowIndex];
            txtNoPemakaian.Text = row.Cells["NoPemakaian"].Value.ToString();
            txtKodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
            txtJumlahPakai.Text = row.Cells["JumlahPakai"].Value.ToString();
            txtJumlahKembali.Text = row.Cells["JumlahKembali"].Value.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //18.
            MessageBox.Show("Transaksi Selesai");

            //
            FCetakPengembalian cetakkembali = new FCetakPengembalian();
            cetakkembali.Show();

            awal();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            //19.
            Close();
        }

    }
}
