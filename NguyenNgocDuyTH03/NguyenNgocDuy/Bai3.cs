using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenNgocDuy
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String[] name=new String[3];
            name[0]=cbxTitle.Text;
            name[1]=txtFirst.Text; 
            name[2]=txtLast.Text;
            String inForm = name[0] + " " + name[1] + " " + name[2]+"\n";
            ArrayList list= new ArrayList();
            list.Add(inForm);
            foreach(String s in list)
            {
                lstInform.Items.Add(s);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }
    }
}
