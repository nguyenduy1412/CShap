using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai30
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;
            lstSinhVien.Items.Add(sv);
        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex != -1)
            {
                SinhVien sv = lstSinhVien.SelectedItem as SinhVien;
                txtMa.Text = sv.Ma.ToString();
                txtTen.Text = sv.Ten;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (lstSinhVien.SelectedIndices.Count > 0)
            {
                lstSinhVien.Items.RemoveAt(lstSinhVien.SelectedIndices[0]);
                txtMa.Text = "";
                txtTen.Text = "";
            }
        }
    }
}
