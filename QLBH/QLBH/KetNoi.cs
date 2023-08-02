using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLBH
{
    class KetNoi
    {
        private string conStr = @"Data Source=DESKTOP-2BKKJ18\SQLEXPRESS;Initial Catalog=Banhang;Integrated Security=True";
        private SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }
        public DataTable layDuLieu(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool thucThi(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
