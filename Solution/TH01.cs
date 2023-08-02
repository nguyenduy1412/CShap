using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNgocDuy
{
    internal class TH01
    {

        public static void Cau1()
        {
            Console.Write("nhap chieu cao: ");
            int h = int.Parse(Console.ReadLine());
            for (int i = 0; i < h; i++)
            {
                for (int j = h - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Cau2()
        {
            Console.Write("Nhap so tu 0 den 9: ");
            int so = int.Parse(Console.ReadLine());
            string[] Array = { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };
            switch (so)
            {
                case 0:
                    Console.WriteLine(Array[0]);
                    break;
                case 1:
                    Console.WriteLine(Array[1]);
                    break;
                case 2:
                    Console.WriteLine(Array[2]);
                    break;
                case 3:
                    Console.WriteLine(Array[3]);
                    break;
                case 4:
                    Console.WriteLine(Array[4]);
                    break;
                case 5:
                    Console.WriteLine(Array[5]);
                    break;
                case 6:
                    Console.WriteLine(Array[6]);
                    break;
                case 7:
                    Console.WriteLine(Array[7]);
                    break;
                case 8:
                    Console.WriteLine(Array[8]);
                    break;
                case 9:
                    Console.WriteLine(Array[9]);
                    break;
                default:
                    break;
            }
        }
        public static void Cau3()
        {
            
            Console.Write("Nhập n: ");
            long n=long.Parse(Console.ReadLine());
            int size = (int)Math.Log10(n) + 1;
            int count = 0;
            long[]x=new long[size];
            while (n>0)
            {
                x[count] = n % 10;
                n /= 10;
                count++;
            }
            string[] text = { "", "muoi", "tram", "nghin", "muoi", "tram", "trieu", "muoi", "tram", "ty" };
            string[] world = { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };
            for (int i = count - 1;i>=0;i--)
            {
                Console.Write(" {0} {1} ", world[x[i]], text[i]);
            }    
        }
        class MonHoc
        {
            public string MaMon { get; set; }
            public string TenMon { get; set; }
            public int SoTinChi { get; set; }
        }
        class TinChi : MonHoc
        {
            public double DiemThanhPhan { get; set; }
            public double DiemThi { get; set; }

            public double TinhDiemTongKet()
            {
                return 0.3 * DiemThanhPhan + 0.7 * DiemThi;
            }
        }
        class SinhVien
        {
            public string MaSV { get; set; }
            public string HoTen { get; set; }
            public int SoLuongTinChiDangKy { get; set; }
            public List<TinChi> DanhSachTinChi { get; set; }

            public double TinhDiemTongKetToanKhoa()
            {
                double diemTongKetToanKhoa = 0;
                int tongSoTinChi = 0;

                foreach (TinChi tinChi in DanhSachTinChi)
                {
                    double diemTongKet = tinChi.TinhDiemTongKet();
                    diemTongKetToanKhoa += diemTongKet * tinChi.SoTinChi;
                    tongSoTinChi += tinChi.SoTinChi;
                }

                return diemTongKetToanKhoa / tongSoTinChi;

            }
        }
        public static void Cau4()
        {
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();

            // Nhập vào từ bàn phím một danh sách Sinh viên
            Console.Write("\nNhập số lượng sinh viên: ");
            int soLuongSinhVien = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuongSinhVien; i++)
            {
                SinhVien sinhVien = new SinhVien();

                Console.Write($"Nhập mã sinh viên {i + 1}: ");
                sinhVien.MaSV = Console.ReadLine();

                Console.Write($"Nhập họ và tên sinh viên {i + 1}: ");
                sinhVien.HoTen = Console.ReadLine();

                Console.Write($"Nhập số lượng tín chỉ đã đăng ký của sinh viên {i + 1}: ");
                sinhVien.SoLuongTinChiDangKy = int.Parse(Console.ReadLine());

                sinhVien.DanhSachTinChi = new List<TinChi>();

                for (int j = 0; j < sinhVien.SoLuongTinChiDangKy; j++)
                {
                    TinChi tinChi = new TinChi();

                    Console.Write($"Nhập mã môn học của tín chỉ {j + 1}: ");
                    tinChi.MaMon = Console.ReadLine();

                    Console.Write($"Nhập tên môn học của tín chỉ {j + 1}: ");
                    tinChi.TenMon = Console.ReadLine();

                    Console.Write($"Nhập số tín chỉ của môn học của tín chỉ {j + 1}: ");
                    tinChi.SoTinChi = int.Parse(Console.ReadLine());

                    Console.Write($"Nhập điểm thành phần của tín chỉ {j + 1}: ");
                    tinChi.DiemThanhPhan = double.Parse(Console.ReadLine());

                    Console.Write($"Nhập điểm thi của tín chỉ {j + 1}: ");
                    tinChi.DiemThi = double.Parse(Console.ReadLine());

                    sinhVien.DanhSachTinChi.Add(tinChi);
                }

                danhSachSinhVien.Add(sinhVien);
            }
            foreach (SinhVien sinhVien in danhSachSinhVien)
            {
                Console.WriteLine($"Mã sinh viên: {sinhVien.MaSV}, Họ và tên: {sinhVien.HoTen}");

                foreach (TinChi tinChi in sinhVien.DanhSachTinChi)
                {
                    Console.WriteLine($"  - Mã môn học: {tinChi.MaMon}, Tên môn học: {tinChi.TenMon}, Số tín chỉ: {tinChi.SoTinChi}, Điểm thành phần: {tinChi.DiemThanhPhan}, Điểm thi: {tinChi.DiemThi}");
                }

                Console.WriteLine();
            }
            // hien thi theo xep loai
            List<SinhVien> svTB = danhSachSinhVien.Where(sv => sv.TinhDiemTongKetToanKhoa() < 6).ToList();
            Console.WriteLine("Danh sách sinh viên xếp loại TB:");
            foreach (SinhVien sv in svTB)
            {
                Console.WriteLine($"{sv.MaSV} - {sv.HoTen} - {sv.TinhDiemTongKetToanKhoa()}");
            }


            // Lọc ra các sinh viên có điểm trung bình 6 <= DTK < 8
            List<SinhVien> svKha = danhSachSinhVien.Where(sv => sv.TinhDiemTongKetToanKhoa() >= 6 && sv.TinhDiemTongKetToanKhoa() < 8).ToList();
            Console.WriteLine("Danh sách sinh viên xếp loại Khá:");
            foreach (SinhVien sv in svKha)
            {
                Console.WriteLine($"{sv.MaSV} - {sv.HoTen} - {sv.TinhDiemTongKetToanKhoa()}");
            }

            // Lọc ra các sinh viên có điểm trung bình DTK >= 8
            List<SinhVien> svGioi = danhSachSinhVien.Where(sv => sv.TinhDiemTongKetToanKhoa() >= 8).ToList();
            Console.WriteLine("Danh sách sinh viên xếp loại Giỏi:");
            foreach (SinhVien sv in svGioi)
            {
                Console.WriteLine($"{sv.MaSV} - {sv.HoTen} - {sv.TinhDiemTongKetToanKhoa()}");
            }
            //sap xep
            List<SinhVien> dsSinhVienSapXep = danhSachSinhVien.OrderByDescending(sv => sv.TinhDiemTongKetToanKhoa()).ToList();
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo DTK giảm dần:");
            foreach (SinhVien sv in dsSinhVienSapXep)
            {
                Console.WriteLine($"{sv.MaSV} - {sv.HoTen} - {sv.TinhDiemTongKetToanKhoa()}");
            }
        }
        class HinhTamGiac
        {
            private int ma, mb, mc;

            public HinhTamGiac()
            {
                ma = 0;
                mb = 0;
                mc = 0;
            }

            public HinhTamGiac(int a, int b, int c)
            {
                if (laTamGiac(a, b, c))
                {
                    ma = a;
                    mb = b;
                    mc = c;
                }
                else
                {
                    Console.WriteLine("Khong phai tam giac");
                    ma = 0;
                    mb = 0;
                    mc = 0;
                }
            }

            public int getCanhA()
            {
                return ma;
            }

            public void setCanhA(int v)
            {
                if (laTamGiac(v, mb, mc))
                {
                    ma = v;
                }
                else
                {
                    Console.WriteLine("Khong phai tam giac");
                }
            }

            public int getCanhB()
            {
                return mb;
            }

            public void setCanhB(int v)
            {
                if (laTamGiac(ma, v, mc))
                {
                    mb = v;
                }
                else
                {
                    Console.WriteLine("Khong phai tam giac");
                }
            }

            public int getCanhC()
            {
                return mc;
            }

            public void setCanhC(int v)
            {
                if (laTamGiac(ma, mb, v))
                {
                    mc = v;
                }
                else
                {
                    Console.WriteLine("Khong phai tam giac");
                }
            }

            public bool laTamGiac()
            {
                return laTamGiac(ma, mb, mc);
            }

            public bool laTamGiac(int a, int b, int c)
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    return false;
                }
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    return false;
                }
                return true;
            }

            public int getChuVi()
            {
                return ma + mb + mc;
            }

            public double getDienTich()
            {
                double p = (ma + mb + mc) / 2.0;
                return Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
            }
        }

        public static void Cau5()
        {
            Console.Write("Nhap canh a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            int c = int.Parse(Console.ReadLine());

            HinhTamGiac htg = new HinhTamGiac(a, b, c);

            if (htg.laTamGiac())
            {
                Console.WriteLine("Chu vi: {0}", htg.getChuVi());
                Console.WriteLine("Dien tich: {0}", htg.getDienTich());
            }
        }
    }
}
 