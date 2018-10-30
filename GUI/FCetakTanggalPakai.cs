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
    public partial class FCetakTanggalPakai : Form
    {
        //2.
        private DataSet ds;
        private SqlDataAdapter da;

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();

        public FCetakTanggalPakai()
        {
            InitializeComponent();
        }

        private void FCetakTanggalPakai_Load(object sender, EventArgs e)
        {
            //4.
            SqlConnection conn = konn.GetConn();
            conn.Open();
            da = new SqlDataAdapter("select * from View_Pemakaian where Tanggal = '" + FLaporan.objLaporan.dtpPerTanggalPakai.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds, "View_Pemakaian");
            Laporan.LaporanTanggalPakai myReportTanggalPakai = new Laporan.LaporanTanggalPakai();
            myReportTanggalPakai.SetDataSource(ds);
            reportTanggalPakai.ReportSource = myReportTanggalPakai;
            reportTanggalPakai.Refresh();
        }
    }
}
