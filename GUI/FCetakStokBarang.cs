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
    public partial class FCetakStokBarang : Form
    {
        //2.
        private DataSet ds;
        private SqlDataAdapter da;

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();

        public FCetakStokBarang()
        {
            InitializeComponent();
        }

        private void FCetakStokBarang_Load(object sender, EventArgs e)
        {
            //4.
            SqlConnection conn = konn.GetConn();
            conn.Open();
            da = new SqlDataAdapter("select * from tbl_barang", conn);
            ds = new DataSet();
            da.Fill(ds, "tbl_barang");
            Laporan.LaporanBarang myReportStokBrg = new Laporan.LaporanBarang();
            myReportStokBrg.SetDataSource(ds);
            crystalReportStokBrg.ReportSource = myReportStokBrg;
            crystalReportStokBrg.Refresh();
        }
    }
}
