using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from Nguoidung where Taikhoan='{0}' and MatKhau='{1}'",
                txtTaiKhoan.Text, txtMatKhau.Text);
            DataTable tb = kn.layDuLieu(query);
            if (tb.Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                HeThong frm = new HeThong();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
