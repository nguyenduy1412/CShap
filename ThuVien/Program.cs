using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    internal class Program
    {
        static void ToanHoc()
        {
            Console.WriteLine("Mời bạn nhập vào số a:");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine($"Căn bậc 2 của {a}={Math.Sqrt(a)}");
            Console.WriteLine("Mời bạn nhập vào số b:");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}^{b}={Math.Pow(a,b)}");

            Console.WriteLine("Mời bạn nhâp vào 1 góc:");
            int goc=Convert.ToInt32(Console.ReadLine());
            double radian = Math.PI * goc / 180;
            Console.WriteLine($"sin({goc})={Math.Sin(radian)}");
            Console.WriteLine($"cos({goc})={Math.Cos(radian)}");
            double x = 7.7777;
            Console.WriteLine("x ban đầu là" + x);
            Console.WriteLine($"x sau khi làm tròn là {Math.Round(x,2)}");

            Console.ReadLine();
        }
        static void TestRandom()
        {
            //hãy xuất số ngẫu nhiên trong đoạn từ 0 đến 100;
            Random rd= new Random();
            int x=rd.Next(50,60);
            Console.WriteLine("Máy ra số ngẫu nhiên =" + x);
        }
        static void TestDateTime()
        {
            DateTime d = new DateTime(1970, 1, 27);
            Console.WriteLine(d.ToString("dd/MM/yyyy"));
            Console.WriteLine(d.ToString("d/M/yyyy"));
            Console.WriteLine("Mời bạn nhập vào năm sinh: ");
            string s=Console.ReadLine();
            DateTime birthday=DateTime.Parse(s);
            Console.WriteLine("Bạn sinh tháng " + birthday.Month);
            Console.WriteLine("Bạn sinh năm "+birthday.Year);
            Console.WriteLine("Bạn sinh ngày " + birthday.Day);

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //ToanHoc();
            //TestRandom();
            TestDateTime();
            Console.ReadLine();
        }
    }
}
