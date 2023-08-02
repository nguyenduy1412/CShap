using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace De4KTra
{
    class KetNoi
    {
        String conStr = @"Data Source=DESKTOP-2BKKJ18\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
        SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }
        public DataTable layDuLieu(string query)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.Fill(tb);
            return tb;
        }
        public bool thucThi(string query)
        {
            try
            {
                conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
