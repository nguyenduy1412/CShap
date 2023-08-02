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
namespace Bai6Ktra
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
            string query = "select * from LopHoc";
            DataTable tb = kn.layDuLieu(query);
            dgv.DataSource = tb;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void clearData()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtGhiChu.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into LopHoc values('{0}',N'{1}',N'{2}')", txtMaLop.Text, txtTenLop.Text, txtGhiChu.Text);
            bool kt = kn.thucThi(query);
            if (kt)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            getData();
            clearData();
        }
    }
}
