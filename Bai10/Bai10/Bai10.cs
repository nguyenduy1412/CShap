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
namespace Bai10
{
    public partial class Bai10 : Form
    {
        String str = @"Data Source=DESKTOP-2BKKJ18\SQLEXPRESS;Initial Catalog=SimThe;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Bai10()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Sim";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        private void Bai10_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                object cellValues = dgv.Rows[i].Cells[0].Value;
                if (cellValues != null && txtId.Text.Equals(cellValues.ToString()))
                {
                    MessageBox.Show("Số sim cần tìm có ngày hết hạn là " + dtpNgayHH.Text);
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("Không tìm thấy kết quả");
            }
        }
    }
}
