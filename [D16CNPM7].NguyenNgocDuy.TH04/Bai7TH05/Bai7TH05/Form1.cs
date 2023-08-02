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
namespace Bai7TH05
{
    public partial class Form1 : Form
    {
        String str = @"Data Source=DESKTOP-2BKKJ18\SQLEXPRESS;Initial Catalog=PMStore;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SanPham";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
   

   

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime selectedDate1 = dtpNSX.Value;
            string formattedDate1 = selectedDate1.ToString("yyyy-MM-dd");
            DateTime selectedDate2 = dtpNSX.Value;
            string formattedDate2 = selectedDate2.ToString("yyyy-MM-dd");
            command = connection.CreateCommand();
            command.CommandText = string.Format("insert into SanPham values (N'{0}',N'{1}',{2},'{3}','{4}','{5}')",
             txtMa.Text, 
             txtTen.Text,
             txtSoLuong.Text,
             formattedDate1, 
             formattedDate2,
             txtNhaCC.Text
             );
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " delete from SanPham where soluongton =0 or NgayHH <  GETDATE()";
            int r=command.ExecuteNonQuery();
            if (r > 0)
                MessageBox.Show("Xóa thành công");
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = String.Format("update SanPham set NhaCungCap='{0}' where MaSP='{1}'", txtNhaCC.Text,txtMa.Text);
            command.ExecuteNonQuery();
            loaddata();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            int n = dgv.RowCount;
            for(int i=0;i<n;i++)
            {
                object cellValues=dgv.Rows[i].Cells[0].Value;
                if(cellValues!=null && txtMa.Text.Equals(cellValues.ToString()))
                {
                    txtNhaCC.Text=dgv.Rows[i].Cells[5].Value.ToString();
                    break;
                }
            }


        }
    }
}
