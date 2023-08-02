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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        KetNoi kn = new KetNoi();
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
            cmbLoaiSP.DataSource = tb;
            cmbLoaiSP.DisplayMember = "Ten";
            cmbLoaiSP.ValueMember = "MaLoaiSP";
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            getLoaiSP();
            getData();
        }

        private void cmbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select SanPham.* from SanPham inner join LoaiSanPham on SanPham.MaLoaiSP=LoaiSanPham.MaLoaiSP where SanPham.Ten like N'%{0}%'",txtTimKiem.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvSanPham.DataSource = tb;
        }
        public void clearText()
        {
            txtMaSP.Text = "";
            txtTen.Text = "";
            txtHinhAnh.Text = "";
            txtDonGia.Text = "0";
            txtMoTaNgan.Text = "";
            txtMTCT.Text = "";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Enabled = true;
            btnThem.Enabled =true;
            btnSua.Enabled =false;
            btnXoa.Enabled =false;
            clearText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into SanPham values('{0}',N'{1}',{2},N'{3}',N'{4}',N'{5}','{6}')",
                txtMaSP.Text,
                txtTen.Text,
                txtDonGia.Text,
                txtHinhAnh.Text,
                txtMoTaNgan.Text,
                txtMTCT.Text,
                cmbLoaiSP.SelectedValue
                );
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
            getData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete SanPham where MaSP ='{0}'",
                txtMaSP.Text
                );
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
            getData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update SanPham set Ten=N'{0}',DonGia={1},HinhAnh=N'{2}',MoTaNgan=N'{3}',MoTaChiTiet=N'{4}',MaLoaiSP='{5}' where MaSP='{6}'", 
                txtTen.Text,
                txtDonGia.Text,
                txtHinhAnh.Text,
                txtMoTaNgan.Text,
                txtMTCT.Text,
                cmbLoaiSP.SelectedValue,
                txtMaSP.Text);
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
            getData();
        }


        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaSP.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaSP.Text = dgvSanPham.Rows[r].Cells[0].Value.ToString() ;
                txtTen.Text = dgvSanPham.Rows[r].Cells[1].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[r].Cells[2].Value.ToString();
                txtHinhAnh.Text = dgvSanPham.Rows[r].Cells[3].Value.ToString();            
                txtMoTaNgan.Text = dgvSanPham.Rows[r].Cells[4].Value.ToString();
                txtMTCT.Text = dgvSanPham.Rows[r].Cells[5].Value.ToString();
                cmbLoaiSP.SelectedValue =dgvSanPham.Rows[r].Cells[6].Value.ToString();
            }
        }
    }
}
