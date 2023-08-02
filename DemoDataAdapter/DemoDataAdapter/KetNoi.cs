using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DemoDataAdapter
{
    class KetNoi
    {
        string conStr= @"Data Source=DESKTOP-2BKKJ18\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
        SqlConnection conn;
        public KetNoi()
        {
            conn= new SqlConnection(conStr);
            conn.Open();
        }
        public DataSet LayDuLieu(string truyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
            DataSet ds= new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool ThucThi(string truyvan)
        {
            SqlCommand cmd = new SqlCommand(truyvan,conn);
            conn.Open();
            int r=cmd.ExecuteNonQuery();
            conn.Close();
            return r>0;
        }
    }
}
