using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Project_PemantauanBarangDisbertam.GUI
{
    public partial class FLaporan : Form
    {
        //Report
        public static FLaporan objLaporan;

        public FLaporan()
        {
            InitializeComponent();
            //Report
            objLaporan = this;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (rbStokBrg.Checked)
            {
                FCetakStokBarang cetakStokBrg = new FCetakStokBarang();
                cetakStokBrg.Show();
            }

            else if (rbPerTanggalPakai.Checked)
            {
                FCetakTanggalPakai cetakTanggalPakai = new FCetakTanggalPakai();
                cetakTanggalPakai.Show();
            }

            else if (rbPeriodePakai.Checked)
            {
                FCetakPeriodePakai cetakPeriodePakai = new FCetakPeriodePakai();
                cetakPeriodePakai.Show();
            }

            else if (rbPerTanggalKembali.Checked)
            {
                FCetakTanggalKembali cetakTanggalKembali = new FCetakTanggalKembali();
                cetakTanggalKembali.Show();
            }

            else if (rbPeriodeKembali.Checked)
            {
                FCetakPeriodeKembali cetakPeriodeKembali = new FCetakPeriodeKembali();
                cetakPeriodeKembali.Show();
            }

            else
            {
                MessageBox.Show("Harap Pilih Terlebih Dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
