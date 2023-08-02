using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong
{
    internal class Program
    {
        static void TestParams()
        {
            Param test= new Param();
            Console.WriteLine(test.Sum(1, 2, 3, 4, 5, 6, 7));
            Console.WriteLine(test.Sum());
            Console.WriteLine(test.Sum(-4, 2, 5, 4, -100));
        }
        static void TestKH()
        {
            List<KhachHang> dsKH= new List<KhachHang>();
            dsKH.Add(new KhachHang() { Ma = 1, Ten = "Ông Tèo", Phone = "23432443" });
            KhachHang baty = new KhachHang();
            baty.Ma = 2;
            baty.Ten = "Bà Tý";
            baty.Phone = "034285r0";
            dsKH.Add(baty);
            dsKH.Add(new KhachHang()
                {
                    Ma = 3,
                    Ten = "Bin",
                    Phone = "3243443",
                }
            );
            foreach (KhachHang kh in dsKH)
            {
                Console.WriteLine(kh.Ma+"\t"+kh.Ten+"\t"+kh.Phone);
            }
        }
        static void TestAliasVaGomRac()
        {
            KhachHang teo = new KhachHang() { Ma = 1, Ten = "Tèo", Phone = "0324934" };
            KhachHang ty = new KhachHang() { Ma = 2, Ten = "Tý", Phone = "08924934" };
            teo = ty;
            teo.Ten = "OBAMA";
            Console.WriteLine("Tên của Tèo là " + ty.Ten);
            KhachHang an = new KhachHang() { Ma = 3, Ten = "An" };
            KhachHang binh=an.copy();
            binh.Ten = "BINH";
            Console.WriteLine("Tên của an là " + an.Ten);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            /*Sinhvien teo=new Sinhvien();
            teo.Ten = "Nguyễn Văn Tèo";
            teo.Ma = 135;
            Console.WriteLine(teo);
            Sinhvien ty=new Sinhvien(114,"Hồ Thị Tý");
            Console.WriteLine(ty);
            Sinhvien an = new Sinhvien();
            an.Ma = 2;
            an.Ten = "Nguyễn Bình An";
            an.NamSinh = new DateTime(2012, 1, 1);
            an.xuatThongTin();*/
            //TestParams();
            //TestKH();
            TestAliasVaGomRac();
            Console.ReadLine();
        }
    }
}
