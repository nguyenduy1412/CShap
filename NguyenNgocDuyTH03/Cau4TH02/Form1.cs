using System.Windows.Forms;

namespace Cau4TH02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            // Lặp qua các mục trong Listbox bên trái
            for (int i = lstTrai.Items.Count - 1; i >= 0; i--)
            {
                if (lstTrai.GetSelected(i))
                {
                    // Thêm mục được chọn vào Listbox bên phải
                    lstPhai.Items.Add(lstTrai.Items[i]);

                    // Xóa mục được chọn khỏi Listbox bên trái
                    lstTrai.Items.RemoveAt(i);
                }
            }
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            for (int i = lstPhai.Items.Count - 1; i >= 0; i--)
            {
                if (lstPhai.GetSelected(i))
                {
                    // Thêm mục được chọn vào Listbox bên phải
                    lstTrai.Items.Add(lstPhai.Items[i]);

                    // Xóa mục được chọn khỏi Listbox bên trái
                    lstPhai.Items.RemoveAt(i);
                }
            }
        }

        private void btnPhaiPhai_Click(object sender, EventArgs e)
        {
            for (int i = lstTrai.Items.Count - 1; i >= 0; i--)
            {
                // Thêm mỗi mục vào danh sách phải
                lstPhai.Items.Add(lstTrai.Items[i]);

                // Xóa mỗi mục khỏi danh sách trái
                lstTrai.Items.RemoveAt(i);
            }
        }

        private void btnTraiTrai_Click(object sender, EventArgs e)
        {
            for (int i = lstPhai.Items.Count - 1; i >= 0; i--)
            {
                // Thêm mỗi mục vào danh sách phải
                lstTrai.Items.Add(lstPhai.Items[i]);

                // Xóa mỗi mục khỏi danh sách trái
                lstPhai.Items.RemoveAt(i);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text.Trim(); // Lấy tên món ăn từ textbox và loại bỏ khoảng trắng đầu cuối
            if (!string.IsNullOrEmpty(tenMon)) // Kiểm tra xem tên món ăn có rỗng hay không
            {
                if (!lstTrai.Items.Contains(tenMon) && !lstPhai.Items.Contains(tenMon))
                {
                    lstTrai.Items.Add(tenMon);
                }
            }
            
        }
    }
}