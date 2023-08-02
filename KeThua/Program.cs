using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    public class Program
    {
        static void TestNhanVien()
        {
            NhanVienChinhThuc teo = new NhanVienChinhThuc();
            teo.Ma = 1;
            teo.Ten = "Nguyễn Văn Tèo";
            Console.WriteLine("Lương của "+teo.Ten+"=");
            teo.TinhLuong();
        }
        static void TestNV2()
        {
            NhanVienChinhThuc teo = new NhanVienChinhThuc();
            int luong=teo.TinhLuong(18);
            Console.WriteLine("Lường của tèo=" + luong);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            TestNV2();
            Console.ReadLine();
        }
    }
}
