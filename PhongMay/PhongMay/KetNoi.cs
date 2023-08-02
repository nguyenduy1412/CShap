﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PhongMay
{
    class KetNoi
    {
        private string strCon = @"";
        private SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(strCon);
        }
        public DataTable layDuLieu(string query)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
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
