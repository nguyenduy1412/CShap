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
    public partial class LoaiNhanVien : Form
    {
        public LoaiNhanVien()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = "select * from LoaiNhanVien";
            DataTable tb = kn.layDuLieu(query);
            dgvLoaiNV.DataSource = tb;
        }
        private void LoaiNhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
