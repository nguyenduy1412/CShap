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
namespace Bai5TH05
{
    public partial class LopHoc : Form
    {
        String str = @"Data Source=DESKTOP-2BKKJ18\SQLEXPRESS;Initial Catalog=HoaHong;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public LopHoc()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from LopHoc";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        private void LopHoc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText="insert into LopHoc values ('"+txtMaLop.Text+"','"+txtTenLop.Text+"','"+txtGhiChu.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int n = dgv.RowCount;
            int r=-1;
            for (int i = 0; i < n; i++)
            {
                object cellValue = dgv.Rows[i].Cells[0].Value;
                if (cellValue != null && cellValue.Equals(dgv.Rows[i].Cells[0].Value.ToString()))
                {
                    command.CommandText = "delete from LopHoc where MaLop ='" + txtMaLop.Text + "'";
                    r=command.ExecuteNonQuery();
                    loaddata();
                    break;
                }
            }
            if (r > 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Không có Lớp học phù hợp");

        }

   
    }
}
