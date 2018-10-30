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
using CrystalDecisions.CrystalReports.Engine;

namespace Project_PemantauanBarangDisbertam.GUI
{
    public partial class FCetakTanggalKembali : Form
    {
        //2.
        private DataSet ds;
        private SqlDataAdapter da;

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();

        public FCetakTanggalKembali()
        {
            InitializeComponent();
        }

        private void FCetakTanggalKembali_Load(object sender, EventArgs e)
        {
            //4.
            SqlConnection conn = konn.GetConn();
            conn.Open();
            da = new SqlDataAdapter("select * from View_Pengembalian where TanggalKembali = '" + FLaporan.objLaporan.dtpPerTanggalKembali.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds, "View_Pengembalian");
            Laporan.LaporanTanggalKembali myReportTanggalKembali = new Laporan.LaporanTanggalKembali();
            myReportTanggalKembali.SetDataSource(ds);
            reportTanggalKembali.ReportSource = myReportTanggalKembali;
            reportTanggalKembali.Refresh();
        }
    }
}
