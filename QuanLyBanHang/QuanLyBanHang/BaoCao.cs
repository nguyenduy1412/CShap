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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
      
        private void BaoCao_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from DatHang where MONTH(NgayDatHang) ={0}",
                txtThang.Text);
            DataTable tb = kn.layDuLieu(query);
            dgvThongKe.DataSource = tb;
            int n = dgvThongKe.RowCount;
            float Tong = 0;
            for (int i = 0; i < n-1; i++)
            {
                string str = dgvThongKe.Rows[i].Cells[4].Value.ToString();
                if (str.Equals(""))
                {
                    continue;
                }
                else
                {
                    Tong += float.Parse(dgvThongKe.Rows[i].Cells[4].Value.ToString());
                }
                
            }
            lbTong.Text = Tong.ToString() ;
        }
    }
}
