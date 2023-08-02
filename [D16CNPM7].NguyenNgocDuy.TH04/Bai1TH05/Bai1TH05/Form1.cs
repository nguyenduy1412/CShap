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
namespace Bai1TH05
{
    public partial class Form1 : Form
    {
        string str = @"Data Source=DESKTOP-2BKKJ18\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter=new SqlDataAdapter();
        DataTable table=new DataTable();
        public Form1()
        {
            InitializeComponent();
          
        }

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from CongDan";
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
            command = connection.CreateCommand();
            command.CommandText = string.Format("insert into CongDan values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',{5},N'{6}')",
            txtCMND.Text , txtMaPhuong.Text , txtTenCD.Text , txtCMND.Text ,cbxGioiTinh.Text,
            txtNamSinh.Text, txtSDT.Text
            );
            command.ExecuteNonQuery();
            loaddata();
        }

        private void txtMaCD_TextChanged(object sender, EventArgs e)
        {
            int n = dgv.RowCount;
            for (int i = 0; i < n; i++)
            {
                object cellValue = dgv.Rows[i].Cells[0].Value;
                if (cellValue != null && txtMaCD.Text.Equals(dgv.Rows[i].Cells[0].Value.ToString()))
                {
                    txtMaPhuong.Text = dgv.Rows[i].Cells[1].Value.ToString();
                    txtTenCD.Text = dgv.Rows[i].Cells[2].Value.ToString();
                    txtCMND.Text = dgv.Rows[i].Cells[3].Value.ToString();
                    cbxGioiTinh.Text = dgv.Rows[i].Cells[4].Value.ToString();
                    txtNamSinh.Text = dgv.Rows[i].Cells[5].Value.ToString();
                    txtSDT.Text = dgv.Rows[i].Cells[6].Value.ToString();
                    break;
                }
                else
                    Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText="update CongDan set TenCD =N'"+txtTenCD.Text+"', CMND='"+txtCMND.Text+"'  where MaCD='"+txtMaCD.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }
        void Clear()
        {
            txtMaPhuong.Clear();
            txtTenCD.Clear();
            txtCMND.Clear();
            cbxGioiTinh.SelectedIndex = -1;
            txtNamSinh.Clear();
            txtSDT.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            int n = dgv.RowCount;
            int r = 0;
            command.CommandText="delete from CongDan where MaCD ='"+txtMaCD.Text+"'";
            r=command.ExecuteNonQuery();
            loaddata();
            if(r>0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Không có công dân phù hợp");
            Clear();
        }
    }
}
