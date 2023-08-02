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
namespace Bai10Ktra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = "select * from Sim";
            DataTable tb = kn.layDuLieu(query);
            dgv.DataSource = tb;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            kn.conn.Open();
            string query=string.Format("select NgayHetHan from Sim where SoSim='{0}'",txtSoSim.Text);
            SqlCommand cmd = new SqlCommand(query, kn.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                DateTime ngayHetHan = reader.GetDateTime(0);
                MessageBox.Show("Ngày hết hạn: "+ngayHetHan.ToShortDateString());
            }
            else
            {
                MessageBox.Show("Không tìm thấy số sim");
            }
            kn.conn.Close();
           
        }
    }
}
