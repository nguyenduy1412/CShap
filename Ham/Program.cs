using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ham
{
    internal class Program
    {
        static int TinhGiaiThua(int n)
        {
            int gt = 1;
            for(int i=1;i<=n;i++)
            {
                gt *= i;
            }    
            return gt;
        }
        static string GiaiPhuongTrinhBac1(double a, double b)
        {
            if (a == 0 && b == 0)
                return "Vô số nghiệm";
            if (a == 0 && b != 0)
                return "Vô nghiệm";
             return "x=" + (-b / a);
        }
        static int Min(int a,int b)
        {
            return Math.Min(a,b);
        }
        static void fn1(int a)
        {
            a = a + 5;
            Console.WriteLine($"a trong ham fn1={a}");
        }
        static void fn2(ref int b)
        {
            b += 2;
            Console.WriteLine($"b trong khi goi ham fn2={b}");
        }
        static void fn3(out int c)
        {
            c = 8;
            Console.WriteLine("c trong hàm fn3={0}", c);
        }
        static void Main(string[] args)
        {
            //int a = 8, b = 15;
            //int t = Min(a, b);
            Console.OutputEncoding = Encoding.UTF8;
            /*int kq = TinhGiai5Thua(5);
            Console.WriteLine($"5!={kq}");
            string nghiem = GiaiPhuongTrinhBac1(0, 8);
            Console.WriteLine(nghiem);*/
            int a = 5;
            int b = 10;
            int c = 10;
            Console.WriteLine($"c trước khi goi ham fn3={c}");
            fn3(out c);
            Console.WriteLine($"c sau khi goi ham fn3={c}");

            //ref phải khoi tao gia tri ban dau

            //Console.WriteLine($"b trước khi goi ham fn2={b}");
            //fn2(ref b);
            //Console.WriteLine($"b sau khi goi ham fn2={b}");
            //Console.WriteLine($"a trước khi goi ham fn1={a}");
            //fn1(a);
            //Console.WriteLine($"a sau khi goi ham fn1={a}");

            Console.ReadLine();
        }
    }
}
