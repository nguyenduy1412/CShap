using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*int a = 5;
            a += 2;
            Console.WriteLine("a={0}", a);
           
            //Nhập vào 1 số hỏi số đó chẵn hay lẻ
            int b;
            Console.WriteLine("Mời bạn nhập số b: ");
            b = int.Parse(Console.ReadLine());
            if (b % 2 == 0)
                Console.WriteLine("{0} là số chẵn", b);
            else
                Console.WriteLine("{0} là số lẻ", b);
            int year;
            Console.WriteLine("Mời bạn nhập vào 1 năm: ");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0|| year%400==0)
                Console.WriteLine("{0} là năm nhuận", year);
            else
                Console.WriteLine("{0} không là năm nhuận", year);
            */
            int a = 5, b = 8, c = 9;
            int z = ++a - b++ - --c + 2;
            Console.WriteLine(z);
            
            Console.ReadLine();
        }
    }
}
