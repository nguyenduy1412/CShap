using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class Diem : Form
    {
        public Diem()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = "select * from Diem";
            DataTable tb =kn.layDuLieu(query);

            dgvDiem.DataSource = tb;
        }
        private void Diem_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void clearText()
        {
            txtMaSV.Text = "";
            txtMaMH.Text = "";
            txtDiemTK.Text = "0";
            txtNamHoc.Text = "0";
            txtKy.Text = "";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnSua.Enabled =false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtMaSV.Enabled =true;
            clearText();
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "insert into Diem values('SV05','MH05',10,9,'2')";
            bool kt = kn.thucThi(query);
            if (kt)
            {
                MessageBox.Show("Thêm thành công");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update Diem set MaMH='{1}', DiemTK={2},Namhoc={3},Kỳ='{4}' where MaSV='{0}'",
               txtMaSV.Text,
               txtMaMH.Text,
               txtDiemTK.Text,
               txtNamHoc.Text,
               txtKy.Text);

            bool kt = kn.thucThi(query);
            if (kt)
            {
                MessageBox.Show("Sửa thành công");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete Diem where MaSV='SV04'");
            bool kt = kn.thucThi(query);
            if (kt)
            {
                MessageBox.Show("Xóa thành công");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                txtMaSV.Enabled = false;
                txtMaSV.Text = dgvDiem.Rows[r].Cells[0].Value.ToString();
                txtMaMH.Text = dgvDiem.Rows[r].Cells[1].Value.ToString();
                txtDiemTK.Text = dgvDiem.Rows[r].Cells[2].Value.ToString();
                txtNamHoc.Text = dgvDiem.Rows[r].Cells[3].Value.ToString();
                txtKy.Text = dgvDiem.Rows[r].Cells[4].Value.ToString();
            }
        }
        
    }
}
