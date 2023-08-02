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
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop frm = new Lop();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diem frm = new Diem();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
