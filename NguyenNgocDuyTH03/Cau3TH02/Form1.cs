namespace Cau3TH01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioButton1.Checked= true;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a=Convert.ToDouble(txtSH1.Text);
            double b = Convert.ToDouble(txtSH2.Text);
            double kq;
            if(radioButton1.Checked==true)
            {
                kq = a + b;
                txtTong.Text=kq.ToString(); 
            }
            else if(radioButton2.Checked==true) 
            {
                kq = a - b;
                txtTong.Text = kq.ToString();
            }
            else if(radioButton3.Checked==true) 
            {
                kq = a * b;
                txtTong.Text = kq.ToString();
            }
            else if(radioButton4.Checked==true)
            {
                kq = a / b;
                txtTong.Text = kq.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}