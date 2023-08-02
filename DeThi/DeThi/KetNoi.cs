using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DeThi
{
    class KetNoi
    {
        private string conStr = @"";
        private SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }
        public System.Data.DataTable LayDuLieu(string truyvan)
        {
            SqlDataAdapter da=new SqlDataAdapter(truyvan,conn)
            DataTable
        }
    }
}
