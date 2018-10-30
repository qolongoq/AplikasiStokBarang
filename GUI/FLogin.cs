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
    public partial class FLogin : Form
    {
        //2.
        private SqlCommand cmd;

        //3.
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //4.
        void bersih()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        public FLogin()
        {
            InitializeComponent();
            //5.
            bersih();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            //6.
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //7.
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_admin where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FMenuUtama.mdiobj.Menu_Master.Enabled = true;
                FMenuUtama.mdiobj.Menu_Transaksi.Enabled = true;
                FMenuUtama.mdiobj.Tool_Pegawai.Enabled = true;
                FMenuUtama.mdiobj.Tool_Barang.Enabled = true;
                FMenuUtama.mdiobj.Tool_Pemakaian.Enabled = true;
                FMenuUtama.mdiobj.Tool_Pengembalian.Enabled = true;
                FMenuUtama.mdiobj.logoutToolStripMenuItem.Enabled = true;
                FMenuUtama.mdiobj.loginToolStripMenuItem.Enabled = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bersih();
            }
            conn.Close();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //8
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //9.
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

    }
}
