using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void HocFor()
        {
            int n;
            Console.WriteLine("Mời bạn nhập số n:");
            n = int.Parse(Console.ReadLine());
            int gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            Console.WriteLine($"{n}!={gt}");
            Console.ReadLine();
        }
        static void HocDoWhile()
        {
            int n;
            Console.WriteLine("Mời bạn nhập số n:");
            n=int.Parse(Console.ReadLine());
            int gt = 1, i = 1;
            do
            {
                gt *= i;
                i++;
            } while (i <= n);
            Console.WriteLine($"{n}!={gt}");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //HocDoWhile();
            HocFor();
        }
    }
}
