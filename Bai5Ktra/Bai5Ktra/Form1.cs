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
namespace Bai5Ktra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KetNoi kn=new KetNoi();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query=string.Format("delete LopHoc where MaLop='{0}'",txtMaLop.Text);
            bool kt = kn.thucThi(query);
            if (kt)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Không có lớp học phù hợp");
            }
            getData();
        }
    }
}
