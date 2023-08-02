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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = "select * from NhanVien";
            DataTable tb = kn.layDuLieu(query);
            dgvNhanVien.DataSource = tb;
        }
        public void getLoaiNV()
        {
            string query = "select * from LoaiNhanVien";
            DataTable tb = kn.layDuLieu(query);
            cmbLoaiNV.DataSource = tb;
            cmbLoaiNV.DisplayMember = "TenLoaiNV";
            cmbLoaiNV.ValueMember = "MaLoaiNV";
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            getLoaiNV();
            getData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select NhanVien.* from NhanVien inner join LoaiNhanVien on NhanVien.MaLoaiNV =LoaiNhanVien.MaLoaiNV where TenLoaiNV like N'%{0}%'", txtTimKiem.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvNhanVien.DataSource = tb;
        }
        public void clearText()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            dtpNgaySinh.Text = "";
            txtDiaChi.Text = "";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled =false;
            btnXoa.Enabled = false;
            clearText();
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into NhanVien values('{0}',N'{1}','{2}',N'{3}','{4}') ",
                txtMaNV.Text,
                txtTenNV.Text,
                dtpNgaySinh.Value.ToString("yyyy-MM-dd"),
                txtDiaChi.Text,
                cmbLoaiNV.SelectedValue
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

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete NhanVien where MaNV ='{0}' ",txtMaNV.Text);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update NhanVien set TenNV=N'{1}' , NgaySinh='{2}', DiaChi=N'{3}',MaLoaiNV='{4}' where MaNV='{0}'",
                txtMaNV.Text,
                txtTenNV.Text,
                dtpNgaySinh.Value.ToString("yyyy-MM-dd"),
                txtDiaChi.Text,
                cmbLoaiNV.SelectedValue
                );
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaNV.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
                cmbLoaiNV.SelectedValue = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            }
        }
    }
}
