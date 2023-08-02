namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.WindowState= FormWindowState.Normal;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Green;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.Text = "Tui đã trờ thành đen thui";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn chọn đóng cửa sổ");
        }
    }
}