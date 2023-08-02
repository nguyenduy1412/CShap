using System;
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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(txtSo.Text, out n))
            {
                string[] text = { "", "mươi", "trăm", "nghìn", "mươi", "trăm", "triệu", "mươi", "trăm", "tỷ" };
                string[] world = { "không", "mot", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string result = "";
                if (n>=10 && n<=19)
                {
                    string s = "mười";
                    if (n == 10)
                        result = s;
                    else
                        result += s + " " + world[n - 10];
                }    
                else
                {
                    int size = (int)Math.Log10(n) + 1;
                    int count = 0;
                    long[] x = new long[size];
                    while (n > 0)
                    {
                        x[count] = n % 10;
                        n /= 10;
                        count++;
                    }
                    

                    for (int i = count - 1; i >= 0; i--)
                    {
                        result += world[x[i]] + " " + text[i] + " ";
                    }
                     
                        

                }   
                txtKQ.Text = result;
            }
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }
    }
}
