using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    public class NhanVien
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public void TinhLuong()
        {
            Console.WriteLine("Đây là phương thức tính lương của nhân viên");
        }
        public virtual int TinhLuong(int ngayCong)
        {
            return ngayCong * 100;
        }
    }
}
