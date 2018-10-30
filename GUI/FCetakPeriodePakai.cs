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
using CrystalDecisions.CrystalReports.Engine;

namespace Project_PemantauanBarangDisbertam.GUI
{
    public partial class FCetakPeriodePakai : Form
    {

        public FCetakPeriodePakai()
        {
            InitializeComponent();
        }

        private void FCetakPeriodePakai_Load(object sender, EventArgs e)
        {
            Laporan.LaporanPeriodePakai myReportPeriodePakai = new Laporan.LaporanPeriodePakai();
            myReportPeriodePakai.SetParameterValue("TanggalMulai", FLaporan.objLaporan.dtpAwalPakai.Text);
            myReportPeriodePakai.SetParameterValue("TanggalSelesai", FLaporan.objLaporan.dtpSelesaiPakai.Text);
            reportPeriodePakai.ReportSource = myReportPeriodePakai;
            reportPeriodePakai.Refresh();
        }


    }
}
