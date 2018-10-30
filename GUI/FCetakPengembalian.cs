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
    public partial class FCetakPengembalian : Form
    {
        //2.
        private DataSet ds;
        private SqlDataAdapter da;

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();


        public FCetakPengembalian()
        {
            InitializeComponent();
        }

        private void FCetakPengembalian_Load(object sender, EventArgs e)
        {
            //4.
            SqlConnection conn = konn.GetConn();
            conn.Open();
            da = new SqlDataAdapter("select * from View_Pengembalian where NoPengembalian = '" + FPengembalian.objPengembalian.txtNoPengembalian.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds, "View_Pengembalian");
            Laporan.LaporanKembali myReportKembali = new Laporan.LaporanKembali();
            myReportKembali.SetDataSource(ds);
            crystalReportKembali.ReportSource = myReportKembali;
            crystalReportKembali.Refresh();
        }

    }
}
