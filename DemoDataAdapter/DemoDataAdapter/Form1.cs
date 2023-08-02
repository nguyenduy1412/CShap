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
namespace DemoDataAdapter
{
    public partial class Form1 : Form
    {
        KetNoi kn=new KetNoi();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }
        // KET NOI 2 BANG inner join Khoa on Lop.MaKhoa =Khoa.MaKhoa
        public void getData()
        {
            String query = "select * from CongDan";           
            DataSet ds= kn.LayDuLieu(query);
            dgv2.DataSource= ds.Tables[0];
        }
        /*public void getData()
        {
            List<Models.Khoa> lst = new List<Models.Khoa>();
            //B1 tao chuoi ket noi CSDL
            String conStr = @"Data Source=DESKTOP-2BKKJ18\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            //b2 mo ket moi csdl
            SqlConnection conn=new SqlConnection(conStr);
            //b3 mo ket noi
            conn.Open();
            //tao truy van va thuc thi
            String query = "select * from CongDan";
            SqlCommand cmd=new SqlCommand(query, conn);
            SqlDataReader rd=cmd.ExecuteReader();
            while (rd.Read())
            {
                Models.Khoa obj=new Models.Khoa();
                obj.Makhoa = (string)rd["MaKhoa"];
                lstAdd(obj);
            }
        }*/
      /*  public void getData_DataSet()
        {
            
            //B1 tao chuoi ket noi CSDL
            String conStr = @"Data Source=DESKTOP-2BKKJ18\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
            //b2 mo ket moi csdl
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            String query = "select * from CongDan";
            //Tao doi tuong dong bo
            SqlDataAdapter da=new SqlDataAdapter(query, conn);
            //tao doi tuong luu tru
            DataSet ds=new DataSet();
            // dong bo du lieu len dataset
            da.Fill(ds,"MaCD");
            //hien thi du lieu da dong bo len Data gird view
            dgv2.DataSource = ds.Tables["CongDan"];
        } */

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into CongDan Values (N'{0}',N'{1},N'{2},N'{3},N'{4},{5},N'{6}");

        }
    }
}
