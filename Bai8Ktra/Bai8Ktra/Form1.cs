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
namespace Bai8Ktra
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
            dgv.DataSource=tb;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMa.Text = dgv.Rows[r].Cells["MaSP"].Value.ToString();
                txtNhaCC.Text = dgv.Rows[r].Cells["NhaCungCap"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update SanPham set NhaCungCap='{0}' where MaSP='{1}'", txtNhaCC.Text, txtMa.Text);
            bool kt = kn.thucThi(query);
            if (kt)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            getData();
        }
    }
}
