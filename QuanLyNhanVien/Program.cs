using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class Program
    {
        static void TestQLNV()
        {
            PhongBan pNS= new PhongBan();
            pNS.MaPhongBan = 1;
            pNS.TenPhongBan = "Phòng Nhân Sự";
            NhanVien teo= new NhanVien();
            teo.MaNhanVien = 1;
            teo.TenNhanVien = "Nguyễn Văn Tèo";
            teo.ChucVu = LoaiChucVu.TRUONG_PHONG;
            pNS.ThemNhanVien(teo);
            
            NhanVien ty = new NhanVien();
            ty.MaNhanVien = 2;
            ty.TenNhanVien = "Tran Thi Ty";
            ty.ChucVu = LoaiChucVu.NHAN_VIEN;
            pNS.ThemNhanVien(ty);
            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty ");
            pNS.XuatToanBoNhanVien();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;

            TestQLNV();
            Console.ReadLine();
        }
    }
}
