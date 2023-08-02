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
namespace De3Ktra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaCD.Text = dgv.Rows[r].Cells["MaCD"].Value.ToString();
                txtCMND.Text = dgv.Rows[r].Cells["CMND"].Value.ToString();
            }
        }
        public void getData()
        {
            string query = "select * from CongDan";
            DataTable tb = kn.layDuLieu(query);
            dgv.DataSource = tb;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update CongDan set CMND ='{0}' where MaCD='{1}'",
                 txtCMND.Text,txtMaCD.Text);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
            txtMaCD.Enabled = false;
        }
    }
}
