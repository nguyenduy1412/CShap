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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSecurity.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSecurity.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSecurity.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSecurity.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSecurity.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSecurity.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSecurity.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            txtSecurity.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSecurity.AppendText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSecurity.AppendText("0");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            
            String date = now.ToString("MM/dd/yyyy h:mm tt");
            String status = "denied";
            String group = "";
            String result = "";
            String[] code = { "6990", "6999", "0100", "9998", "1006", "1008", "1007" };
            String[] groups = { "Technicians", "Technicians", "Custodians", "Scientist", "Scientist", "Scientist" };
            String textCode = txtSecurity.Text;
            for (int i = 0; i < code.Length; i++)
            {
                if (textCode.Equals(code[i]))
                {
                    group = groups[i];
                    status = "granted";
                }
            }
            if (textCode.Length == 1)
            {
                result += date + " " + "Restricted";
            }
            else if (status.Equals("granted"))
            {
                result += date + " " + group;
            }
            else
            {
                result += date + " " + textCode;
            }
            ArrayList list = new ArrayList();
            list.Add(result);
            foreach (String s in list)
            {
                lstDS.Items.Add(s);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtSecurity.Text = "";
        }
    }
}
