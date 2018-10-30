using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PemantauanBarangDisbertam.GUI
{
    public partial class FMenuUtama : Form
    {
        //16.
        public static FMenuUtama mdiobj;

        //3.
        GUI.FPegawai pegawai;

        //4.
        GUI.FBarang brg;

        //5.
        GUI.FPemakaian pakai;

        //6.
        GUI.FPengembalian kembali;

        //
        GUI.FLaporan laporan;


        public FMenuUtama()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1.
            if (MessageBox.Show("Keluar dari Aplikasi ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Tool_Keluar_Click(object sender, EventArgs e)
        {
            //2.
            exitToolStripMenuItem_Click(sender, e);
        }


        //7.
        void Proc_PegawaiClosed(Object sender, FormClosedEventArgs e)
        {
            pegawai = null;
        }

        //7.
        void Proc_BarangClosed(Object sender, FormClosedEventArgs e)
        {
            brg = null;
        }

        //8.
        void Proc_PemakaianClosed(Object sender, FormClosedEventArgs e)
        {
            pakai = null;
        }

        //9.
        void Proc_PengembalianClosed(Object sender, FormClosedEventArgs e)
        {
            kembali = null;
        }

        //
        void Proc_LaporanClosed(Object sender, FormClosedEventArgs e)
        {
            laporan = null;
        }


        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //8.
            if (pegawai == null)
            {
                pegawai = new GUI.FPegawai();
                pegawai.MdiParent = this;
                pegawai.FormClosed += new FormClosedEventHandler(Proc_PegawaiClosed);
                pegawai.Show();
            }
            else
            {
                pegawai.Activate();
            }
        }

        private void Tool_Pegawai_Click(object sender, EventArgs e)
        {
            //9.
            dataPegawaiToolStripMenuItem_Click(sender, e);
        }


        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //10.
            if (brg == null)
            {
                brg = new GUI.FBarang();
                brg.MdiParent = this;
                brg.FormClosed += new FormClosedEventHandler(Proc_BarangClosed);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }
        }

        private void Tool_Barang_Click(object sender, EventArgs e)
        {
            //11.
            dataBarangToolStripMenuItem_Click(sender, e);
        }


        private void pemakaianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //12.
            if (pakai == null)
            {
                pakai = new GUI.FPemakaian();
                pakai.MdiParent = this;
                pakai.FormClosed += new FormClosedEventHandler(Proc_PemakaianClosed);
                pakai.Show();
            }
            else
            {
                pakai.Activate();
            }
        }

        private void Tool_Pemakaian_Click(object sender, EventArgs e)
        {
            //13.
            pemakaianToolStripMenuItem_Click(sender, e);
        }


        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //14.
            if (kembali == null)
            {
                kembali = new GUI.FPengembalian();
                kembali.MdiParent = this;
                kembali.FormClosed += new FormClosedEventHandler(Proc_PengembalianClosed);
                kembali.Show();
            }
            else
            {
                kembali.Activate();
            }
        }

        private void Tool_Pengembalian_Click(object sender, EventArgs e)
        {
            //15.
            pengembalianToolStripMenuItem_Click(sender, e);
        }

        private void FMenuUtama_Load(object sender, EventArgs e)
        {
            //17.
            Menu_Master.Enabled = false;
            Menu_Transaksi.Enabled = false;
            Tool_Pegawai.Enabled = false;
            Tool_Barang.Enabled = false;
            Tool_Pemakaian.Enabled = false;
            Tool_Pengembalian.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = true;

            mdiobj = this;

            GUI.FLogin login = new GUI.FLogin();
            login.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //18.
            Menu_Master.Enabled = false;
            Menu_Transaksi.Enabled = false;
            Tool_Pegawai.Enabled = false;
            Tool_Barang.Enabled = false;
            Tool_Pemakaian.Enabled = false;
            Tool_Pengembalian.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = true;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //19.
            GUI.FLogin login = new GUI.FLogin();
            login.ShowDialog();
        }

        private void laporanLaporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            if (laporan == null)
            {
                laporan = new GUI.FLaporan();
                laporan.MdiParent = this;
                laporan.FormClosed += new FormClosedEventHandler(Proc_LaporanClosed);
                laporan.Show();
            }
            else
            {
                laporan.Activate();
            }
        }

    }
}
