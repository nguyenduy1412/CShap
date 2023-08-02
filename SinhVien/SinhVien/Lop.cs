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
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = "select * from Lop";
            DataTable tb = kn.layDuLieu(query);
            dgvLop.DataSource = tb;
        }
        private void Lop_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
