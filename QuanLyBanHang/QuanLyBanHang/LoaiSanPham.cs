using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class LoaiSanPham : Form
    {
        public LoaiSanPham()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = "select * from LoaiSanPham";
            DataTable tb = kn.layDuLieu(query);
            dgvLoaiSP.DataSource = tb;
        }
        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
