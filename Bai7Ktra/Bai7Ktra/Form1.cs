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
namespace Bai7Ktra
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
            string query = "select * from SanPham";
            DataTable tb = kn.layDuLieu(query);
            dgv.DataSource = tb;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query =string.Format("insert into sanpham values('{0}',N'{1}',{2},'{3}','{4}','{5}') ",
                txtMa.Text,
                txtTen.Text,
                txtSoLuong.Text,
                dtpNgaySX.Value.ToString("yyyy-MM-dd"),
                dtpNgayHH.Value.ToString("yyyy-MM-dd"),
                txtNhaCC.Text
                );
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
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r > 0)
            {
                txtMa.Text = dgv.Rows[r].Cells["MaSP"].Value.ToString();
                dtpNgaySX.Text = dgv.Rows[r].Cells["NgaySX"].Value.ToString();
            }
        }
    }
}
