using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3_3
{

    public partial class Form1 : Form
    {
        Form2 frm = new Form2();
        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;
            if (TaiKhoan == "admin" && MatKhau == "123")
            {
                MessageBox.Show("Đăng nhập thành công");
                //tạo đối tượng
                
                
                //ẩn
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            Application.Exit();
        }
       private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor= Color.LightBlue;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frm.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            frm.Hide();
        }
    }
}
 