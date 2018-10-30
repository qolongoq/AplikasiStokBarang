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
    public partial class FCetakPeriodeKembali : Form
    {
        public FCetakPeriodeKembali()
        {
            InitializeComponent();
        }

        private void FCetakPeriodeKembali_Load(object sender, EventArgs e)
        {
            Laporan.LaporanPeriodeKembali myReportPeriodeKembali = new Laporan.LaporanPeriodeKembali();
            myReportPeriodeKembali.SetParameterValue("TanggalMulai", FLaporan.objLaporan.dtpAwalKembali.Text);
            myReportPeriodeKembali.SetParameterValue("TanggalSelesai", FLaporan.objLaporan.dtpSelesaiKembali.Text);
            reportPeriodeKembali.ReportSource = myReportPeriodeKembali;
            reportPeriodeKembali.Refresh();
        }
    }
}
