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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            getLoaiSP();
            getData();
        }
        public void getData()
        {
            string query = "select * from SanPham";
            DataTable tb = kn.layDuLieu(query);
            dgvSanPham.DataSource = tb;
        }
        public void getLoaiSP()
        {
            string query = "select * from LoaiSanPham";
            DataTable tb = kn.layDuLieu(query);
            cbxMaLoaiSP.DataSource = tb;
            cbxMaLoaiSP.DisplayMember = "Ten";
            cbxMaLoaiSP.ValueMember = "MaLoaiSP";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select SanPham.* from SanPham inner join LoaiSanPham on SanPham.MaLoaiSP =LoaiSanPham.MaLoaiSP where LoaiSanPham.Ten like N'%{0}%'", txtTimKiem.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvSanPham.DataSource = tb;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public void clearText()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGia.Text = "0";
            txtHinhAnh.Text = "";
            txtMTCT.Text = "";
            txtMTNgan.Text = "";
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            getData();
            clearText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query=string.Format("insert into SanPham values('{0}','{1}',{2},N'{3}',N'{4}',N'{5}','{6}')",
                txtMaSP.Text,
                txtTenSP.Text,
                txtGia.Text,
                txtHinhAnh.Text,
                txtMTNgan.Text,
                txtMTCT.Text,
                cbxMaLoaiSP.SelectedValue);
            bool kt = kn.thucThi(query);
            if (kt)
            {
                MessageBox.Show("Thêm thành công");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update SanPham set Ten='{1}',DonGia={2},HinhAnh='{3}',MoTaNgan='{4}',MoTaChiTiet='{5}',MaLoaiSP='{6}' where MaSP='{0}'",
               txtMaSP.Text,
               txtTenSP.Text,
               txtGia.Text,
               txtHinhAnh.Text,
               txtMTNgan.Text,
               txtMTCT.Text,
               cbxMaLoaiSP.SelectedValue);
            bool kt = kn.thucThi(query);
            if (kt)
            {
                MessageBox.Show("Sửa thành công");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete SanPham where MaSP='{0}'", txtMaSP.Text);
            bool kt = kn.thucThi(query);
            if (kt)
            {
                MessageBox.Show("Xóa thành công");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaSP.Text = dgvSanPham.Rows[r].Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[r].Cells[1].Value.ToString();
                txtGia.Text = dgvSanPham.Rows[r].Cells[2].Value.ToString();
                txtHinhAnh.Text = dgvSanPham.Rows[r].Cells[3].Value.ToString();
                txtMTNgan.Text = dgvSanPham.Rows[r].Cells[4].Value.ToString();
                txtMTCT.Text = dgvSanPham.Rows[r].Cells[5].Value.ToString();
                cbxMaLoaiSP.Text =dgvSanPham.Rows[r].Cells[6].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
