using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau1
{
    class Program
    {
        static void PTB1(double a,double b)
        {
            
            if (a == 0)
            {
                if (b != 0)
                    Console.WriteLine("Phương trình vô nghiệm");
                if (b == 0)
                    Console.WriteLine("Phương trình vô số nghiệm");
            }
            else
            {
                Console.WriteLine("Nghiệm của phương trình là " + (-b) / a);
            }
        }
        static void PTB2(double a, double b, double c)
        {
            if (a == 0)
                PTB1(b, c);
            else
            {
                string str = "";
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    str = "Phương trình vô nghiệm";
                else if (delta == 0)
                    str = (b == 0) ? "Phương trình có nghiệm kép x1=x2=0" : "Phương trình có nghiệm kép x1=x2=" + -b / (2 * a);
                else
                {
                    str = "Phương trình có 2 nghiệm phân bịệt x1=" + (-b + Math.Sqrt(delta)) / (2 * a) + "và x2=" + (-b - Math.Sqrt(delta)) / (2 * a);
                }
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            double a, b;
            Console.WriteLine("Mời bạn nhập a ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập b ");
            b = double.Parse(Console.ReadLine());
            PTB1(a,b);
            double c;
            Console.WriteLine("Mời bạn nhập a ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập b ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập c ");
            c = double.Parse(Console.ReadLine());
            PTB2(a,b,c);

            Console.ReadLine();
        }
    }
}
