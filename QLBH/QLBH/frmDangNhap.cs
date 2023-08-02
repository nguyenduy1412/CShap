using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // viết được truy vấn kiểm tra đăng nhập
            string query = string.Format("select * from Nguoidung where TaiKhoan='{0}' and MatKhau='{1}'",txtTaiKhoan.Text,txtMatKhau.Text);
            DataTable tb = kn.layDuLieu(query);
            if (tb.Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmHeThong frm = new frmHeThong();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
