using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau2
{
    internal class Program
    {
        class ConNguoi
        {
            private string CMND;
            private string hoTen;
            private string gioiTinh;
            private int namSinh;
            public ConNguoi() { }
            public ConNguoi(string CMND, string hoTen, string gioiTinh, int namSinh)
            {
                this.CMND = CMND;
                this.hoTen = hoTen;
                this.gioiTinh = gioiTinh;
                this.namSinh = namSinh;
            }
            public virtual void Nhap()
            {
                Console.Write("CMND: ");
                CMND = Console.ReadLine();
                Console.Write("Ho Ten: ");
                hoTen = Console.ReadLine();
                Console.Write("Gioi Tinh: ");
                gioiTinh= Console.ReadLine();
                Console.Write("Nam sinh: ");
                namSinh=int.Parse(Console.ReadLine());
            }
            public virtual void Xuat()
            {
                Console.WriteLine("CMND " + CMND);
                Console.WriteLine("Ho Ten " + hoTen);
                Console.WriteLine("Gioi Tinh " + gioiTinh);
                Console.WriteLine("Nam sinh " + namSinh);
            }
            public virtual double TinhLuong()
            {
                return 0;
            }

        }


        class BienChe : ConNguoi
        {
            private string maBC;
            private double heSoLuong;
            private static double nenLuong = 1410000;
            public BienChe() { }
            public BienChe(string maBC,double heSoLuong,string CMND,string hoTen,string gioiTinh,int namSinh) : base(CMND,hoTen,gioiTinh,namSinh)
            {
                this.maBC = maBC;
                this.heSoLuong= heSoLuong;
            }
            public override void Nhap()
            {
                Console.Write("Ma Bien Che ");
                maBC= Console.ReadLine();
                Console.Write("He so luong ");
                heSoLuong= double.Parse(Console.ReadLine());
                base.Nhap();
            }
            public override void Xuat()
            {
                Console.WriteLine("Ma bien che " + maBC);
                Console.WriteLine("Hẹ so luong " + heSoLuong);
                Console.WriteLine("Nen luong " + nenLuong);
                Console.WriteLine("Luong " + TinhLuong());
                base.Xuat();
                Console.WriteLine();
            }
            public override double TinhLuong()
            {
                return heSoLuong*nenLuong;
            }
        }

        class HopDong : ConNguoi
        {
            private string maHD;
            private double mucLuong;
            private int ngayCong;
            public HopDong() { }
            public HopDong(string maHD,double mucLuong,int ngayCong,string CMND,string hoTen,string gioiTinh,int namSinh): base(CMND, hoTen, gioiTinh, namSinh) 
            {
                this.maHD= maHD;
                this.mucLuong= mucLuong;
                this.ngayCong= ngayCong;
            }
            public override void Nhap()
            {
                Console.Write("Ma Hop Dong ");
                maHD = Console.ReadLine();
                Console.Write("Muc luong ");
                mucLuong = double.Parse(Console.ReadLine());
                Console.Write("Ngay cong ");
                ngayCong=int.Parse(Console.ReadLine());
                base.Nhap();
            }
            public override void Xuat()
            {
                Console.WriteLine("Ma hop dong " + maHD);
                Console.WriteLine("Muc luong " + mucLuong);
                Console.WriteLine("Ngay cong " + ngayCong);
                Console.WriteLine("Luong "+TinhLuong());
                base.Xuat();
                Console.WriteLine();
            }
            public override double TinhLuong()
            {
                return mucLuong * ngayCong;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap so luong nhan su ");
            int n = int.Parse(Console.ReadLine());
            ConNguoi[] dsNhanSu = new ConNguoi[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin nhan su thu " + (i + 1));
                Console.Write("Chon loai nhan su (1 - Bien che, 2 - Hop dong): ");
                int loai = int.Parse(Console.ReadLine());

                switch (loai)
                {
                    case 1:
                        BienChe nvBC = new BienChe();
                        nvBC.Nhap();
                        dsNhanSu[i] = nvBC;
                        break;
                    case 2:
                        HopDong nvHD = new HopDong();
                        nvHD.Nhap();
                        dsNhanSu[i] = nvHD;
                        break;
                    default:
                        Console.WriteLine("Khong co loai nhan su nay.");
                        i--;
                        break;
                }
            }

            Console.WriteLine("Thong tin tat ca nhan su:");
            foreach (ConNguoi item in dsNhanSu)
            {
                item.Xuat();
                item.TinhLuong();
                
            }
            double tongLuong = 0;
            foreach (ConNguoi item in dsNhanSu)
            {
                
                tongLuong+=item.TinhLuong();

            }
            Console.WriteLine("Tong luong Doanh nghiep phai tra la " + tongLuong);
            Console.ReadLine();
        }
    }
}
