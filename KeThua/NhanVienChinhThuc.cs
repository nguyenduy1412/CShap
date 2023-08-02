using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    public class NhanVienChinhThuc : NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Đây là phương thức tính lương của Nhân viên chính thức");
        }
        public override int TinhLuong(int ngayCong)
        {
            if (ngayCong == 20)
                return 10000;
            return base.TinhLuong(ngayCong);
        }
    }
}
