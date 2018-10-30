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
    public partial class FPemakaian : Form
    {
        //Report
        public static FPemakaian objPemakaian;

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
            txtNoPemakaian.Text = "";
            dtpTanggalPakai.Value = DateTime.Now;
            txtIDPegawai.Text = "";
            txtNamaPegawai.Text = "";
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtJumlahPakai.Text = "0";
            txtKeterangan.Text = "";
        }

        //5.
        private void awal()
        {
            bersih();
            dataGridPemakaian.Enabled = false;
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pemakaian order by NoPemakaian desc", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pemakaian");
                    dataGridPemakaian.DataSource = ds;
                    dataGridPemakaian.DataMember = "tbl_pemakaian";
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
        }

        //6.
        private void auto_number()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select NoPemakaian from tbl_pemakaian where NoPemakaian in(select max(NoPemakaian) from tbl_pemakaian) order by NoPemakaian desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoPemakaian"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "P" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "P0001";
            }
            rd.Close();
            txtNoPemakaian.Text = urut;
            conn.Close();
        }

        //7.
        private void Simpan_MasterPemakaian()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tbl_pemakaian values ('" + txtNoPemakaian.Text + "','" + dtpTanggalPakai.Text + "','" + txtIDPegawai.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //8.
        private void Simpan_DetailPemakaian()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tbl_detail_pemakaian values('" + txtNoPemakaian.Text + "','" + txtKodeBarang.Text + "','" + txtJumlahPakai.Text + "','" + txtKeterangan.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //9.
        private void refresh_pemakaian()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from View_Detail_Pemakaian where NoPemakaian = '" + txtNoPemakaian.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "View_Detail_Pemakaian");
                    dataGridPemakaian.DataSource = ds;
                    dataGridPemakaian.DataMember = "View_Detail_Pemakaian";
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
        }

        //10.
        private void RefreshTransaksi()
        {
            refresh_pemakaian();
            txtKodeBarang.Clear();
            txtNamaBarang.Clear();
            txtJumlahPakai.Text = "0";
            txtKeterangan.Text = "";
            txtKodeBarang.Focus();
        }


        public FPemakaian()
        {
            InitializeComponent();
            //Report
            objPemakaian = this;
            //11.
            awal();
        }


        private void btnCariPegawai_Click(object sender, EventArgs e)
        {
            //12.
            FCariPegawai caripegawai = new FCariPegawai();
            caripegawai.ShowDialog();
            txtIDPegawai.Text = caripegawai.ambil_id_pegawai;
            txtNamaPegawai.Text = caripegawai.ambil_nama_pegawai;
            txtKodeBarang.Focus();
        }

        private void btnCariBarang_Click(object sender, EventArgs e)
        {
            //13.
            FCariBarang caribrg = new FCariBarang();
            caribrg.ShowDialog();
            txtKodeBarang.Text = caribrg.ambil_kode_barang;
            txtNamaBarang.Text = caribrg.ambil_nama_barang;
            txtJumlahPakai.Focus();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            //14.
            awal();
            auto_number();
            dtpTanggalPakai.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            //15.
            dataGridPemakaian.Enabled = true;
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                if (txtNoPemakaian.Text.Trim() == "" || txtIDPegawai.Text.Trim() == "" || 
                    txtKodeBarang.Text.Trim() == "" || txtJumlahPakai.Text.Trim() == "0" || txtKeterangan.Text.Trim() == "")
                {
                    MessageBox.Show("Data belum lengkap, lengkapi kembali", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pemakaian where NoPemakaian = '" + txtNoPemakaian.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        conn.Close();
                        conn.Open();
                        cmd = new SqlCommand("select * from tbl_detail_pemakaian where NoPemakaian = '" + txtNoPemakaian.Text + "' and KodeBarang = '" + txtKodeBarang.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Data Barang " + txtNamaBarang.Text + " Sudah Diinputkan, Harap Pilih Barang Yang Lain", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Simpan_DetailPemakaian();
                        }
                    }
                    else
                    {
                        Simpan_MasterPemakaian();
                        Simpan_DetailPemakaian();
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
                cmd = new SqlCommand("delete from tbl_detail_pemakaian where NoPemakaian = '" + txtNoPemakaian.Text + "' and KodeBarang = '" + txtKodeBarang.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("select * from tbl_detail_pemakaian where NoPemakaian = '" + txtNoPemakaian.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                RefreshTransaksi();
            }
        }

        private void dataGridPemakaian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //17.
            DataGridViewRow row = this.dataGridPemakaian.Rows[e.RowIndex];
            txtKodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
            txtNamaBarang.Text = row.Cells["NamaBarang"].Value.ToString();
            txtJumlahPakai.Text = row.Cells["JumlahPakai"].Value.ToString();
            txtKeterangan.Text = row.Cells["Keterangan"].Value.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //18.
            MessageBox.Show("Transaksi Selesai");
            FCetakPemakaian cetakpakai = new FCetakPemakaian();
            cetakpakai.Show();
            awal();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            //19.
            Close();
        }

    }
}
