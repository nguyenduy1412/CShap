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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtNhapSo.Text);
            lstSo.Items.Add(x);
        }
        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                sum+=x;
            }
            MessageBox.Show("Tổng các phần tử ="+sum);
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            //kiểm tra người dùng có đang chọn hay không
            /*if (lstSo.SelectedIndex != -1)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndex);
            }*/
            while (lstSo.SelectedIndices.Count > 0)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[0]);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x=(int)lstSo.Items[i];
                lstSo.Items[i]=x+2;
            }
        }

        private void btnChonChan_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 == 0)
                    lstSo.SelectedIndex = i;
            }

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThayBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                lstSo.Items[i] = x*x;
            }
        }

        private void btnChonLe_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 != 0)
                    lstSo.SelectedIndex = i;
            }
        }


    }
}
