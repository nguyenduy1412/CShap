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
    public partial class Form1 : Form
    {
        KetNoi kn = new KetNoi();
        public Form1()
        {
            InitializeComponent();
        }
        public void getData()
        {
            string query = "select * from CongDan";
            DataTable tb = kn.layDuLieu(query);
            dgv.DataSource = tb;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void txtMaCD_TextChanged(object sender, EventArgs e)
        {        
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete CongDan where MaCD='{0}'", txtMaCD.Text);
            bool kt = kn.thucThi(query);
            if (kt)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            getData();
        }

    }
}

        