using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1KTra
{
    public partial class CongDan : Form
    {
        public CongDan()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = "select * from CongDan";
            DataTable tb = kn.LayDuLieu(query);
            dgv.DataSource = tb;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string query=string.Format("insert into CongDan values('{0}','{1}',N'{2}','{3}',N'{4}','{5}','{6}') " ,
            txtMaCD.Text,
            txtMaPhuong.Text,
            txtTenCD.Text,
            txtCMND.Text,
            cbxGioiTinh.Text,
            txtNamSinh.Text,
            txtSDT.Text);
            bool kt = kn.ThucThi(query);
            if (kt)
            {
                MessageBox.Show("Thêm mới thành công");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            getData();
        }

        private void CongDan_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void clearText()
        {
            txtCMND.Text = "";
            txtTenCD.Text = "";
            txtMaPhuong.Text = "";
            txtCMND.Text = "";
            txtNamSinh.Text = "";
            cbxGioiTinh.Text = "";
            txtSDT.Text = "";
        }

    }
}
