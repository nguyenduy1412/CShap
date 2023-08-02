using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_12_2023
{
    internal class Program
    {
        class ConNguoi
        {
            private string CMND;
            private string HoTen;
            public ConNguoi() { }
            public ConNguoi(string CMND,string HoTen)
            {
                this.CMND=CMND;
                this.HoTen=HoTen;
            }
            public virtual void Nhap()
            {
                Console.Write("CMND: ");
                CMND=Console.ReadLine();
                Console.Write("Ho Ten: ");
                HoTen=Console.ReadLine();
            }
            public virtual void Xuat()
            {
                Console.Write(" CMND: "+CMND);
                Console.Write(" Ho Ten: "+HoTen);
            }
        }
        class GiangVien : ConNguoi
        {
            private string MaGV;
            private string MaKhoa;
                public GiangVien(){}
            public GiangVien(string MaGV, string MaKhoa, string CMND, string HoTen)
                : base(CMND, HoTen)
            {
                this.MaGV = MaGV;
                this.MaKhoa = MaKhoa;
            }
            public override void Nhap()
            {
                Console.Write("MAGV: ");
                MaGV = Console.ReadLine();
                Console.Write("Ma Khoa: ");
                MaKhoa = Console.ReadLine();
                base.Nhap();
            }
            public override void Xuat()
            {
                Console.Write(" MAGV: " + MaGV);
                Console.Write(" Ma Khoa: " + MaKhoa);
                base.Xuat();
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n;
            ConNguoi cn = new GiangVien();
            cn.Nhap();
            cn.Xuat();

            /*Console.WriteLine("Nhap n: ");
            n=Convert.ToInt32(Console.ReadLine());
            GiangVien[] arr=new GiangVien[n];

            Console.WriteLine("Nhap mang: ");
            for(int i=0; i<arr.Length; i++) 
            {
                arr[i] = new GiangVien();
                arr[i].Nhap();
            }
            Console.WriteLine("Mang vua nhap la: ");
 //           for(int i=0; i<arr.Length; i++) 
   //         {
     //           Console.WriteLine(arr[i] + " ");
       //     }

            foreach(GiangVien item in arr) 
            { 
                item.Xuat();
            }*/

            Console.ReadKey();
        }
    }
}
