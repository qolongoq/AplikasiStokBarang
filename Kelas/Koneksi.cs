using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.
using System.Data.SqlClient;

namespace Project_PemantauanBarangDisbertam.Kelas
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = ARKA-PC; Initial Catalog = DB_Gudang; Integrated Security = True";
            return conn;
        }
    }
}
