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
namespace DeThi
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
        public void btnDN()
        {
            string query = string.Format("select * form Nguoidung where TaiKHOAN='{0}' and Matkhau='{1}'", txtTaiKhoan.text, txtMatkhau.text);
            DataTable tb = kn.LayDuLieu(query);
            if(tb.Rows.Count ==1 ) {
                MessageBox.Show("Dang nhap thanh cong");

            }
        }
    }
}
