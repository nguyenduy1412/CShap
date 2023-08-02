﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from Nguoidung where Taikhoan=N'{0}' and Matkhau=N'{1}'",
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
                MessageBox.Show("Đăng nhập không thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
