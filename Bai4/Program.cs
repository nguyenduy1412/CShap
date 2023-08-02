using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            /*double x;
            
            Console.WriteLine("Mời bạn nhập vào 1 điểm:");
            x = double.Parse(Console.ReadLine());
            if (diem >= 5)
                Console.WriteLine("Điểm ={0} đậu", diem);
            else
                Console.WriteLine("Điểm ={0} rớt", diem);
            
            string ketqua = x >= 8 ? "Giỏi" : x >= 6.5 ? "Khá" : x >= 5 ? "Trung bình" : "Yếu";

            Console.WriteLine("Điểm={0}->{1}",x,ketqua);
            */
            int a, b;
            char kt;
            Console.WriteLine("Nhập a: ");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            b =int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phép toán(+,-,*,/");
            kt=char.Parse(Console.ReadLine());
            switch (kt)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    if (b == 0)
                        Console.WriteLine("Mẫu số bằng 0 nên không thực hiện được");
                    else
                        Console.WriteLine("{0}/{1}={2}", a, b, (float)a/ (float)b);
                    break;
            }
          
            Console.ReadLine(); 

        }
    }
}
