using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblManHinh_Click(object sender, EventArgs e)
        {

        }

        private void txtChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string detai = "";
            detai = "Thông tin khách hàng:";
            detai += "\r\nHọ và tên khách hàng: " + txtTen.Text;
            detai += "\r\nSố điện thoại: " + txtPhone.Text;
            detai += "\r\nSản phẩm khách hàng đặt:";
            foreach (object item in lstSanPham.SelectedItems)
            {
                detai += "\r\n" + item.ToString();
            }
            string selectedValue = cboPhuongThuc.SelectedItem as string;
            if (selectedValue != null)
            {
                detai += "\r\nHình thức thanh toán: " + selectedValue;
            }
            else
            {
                detai += "\r\nHình thức thanh toán: " + cboPhuongThuc.Text;
            }
            errorProvider1.SetError(txtTen, "");
            errorProvider1.SetError(txtPhone, "");
            errorProvider1.SetError(cboPhuongThuc, "");
           
            if (txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Tên không được bỏ trống");
                MessageBox.Show("Tên không được bỏ trống");
                return;
            }
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Số điện không được bỏ trống");
                MessageBox.Show("Số điện thoại không được bỏ trống");
                return;
            }
            if (lstSanPham.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
                return;
            }
            if(cboPhuongThuc.Text=="")
            {
                errorProvider1.SetError(cboPhuongThuc, "Phương thức thanh toán không được bỏ trống");
                MessageBox.Show("Phương thức thanh toán không được bỏ trống");
                return;
            }
            txtChiTiet.Text = detai;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Hỏi thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
