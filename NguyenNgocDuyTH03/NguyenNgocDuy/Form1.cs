namespace NguyenNgocDuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            float[] a = new float[3];
            
            a[0] =float.Parse(txtA.Text);
            a[1]= float.Parse(txtB.Text);
            a[2] = float.Parse(txtC.Text);
            float max=a.Max();
            float min=a.Min();
            txtMax.Text= max.ToString();
            txtMin.Text= min.ToString();
            
        }
    }
}