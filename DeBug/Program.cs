using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeBug
{
    internal class Program
    {
        static string GiaiPhuongTrinhBac2(int a,int b,int c)
        {
            if(a==0)
            {
                if(b==0 && c==0)
                {
                    return "Vô số nghiệm";
                }
                if (b == 0 && c != 0)
                    return "Vô nghiệm";
                return "x=" + (-c*1.0 / b);
            }  
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                    return "Vô nghiệm";
                if (delta == 0)
                {
                    double x = -b / 2 * a;
                    return "Nghiệm kép x1=x2=" + x;
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta) )/ (2 * a);
                    double x2 = (-b + Math.Sqrt(delta) )/ (2 * a);
                    return "x1=" + x1 + ";x2="+x2;

                }
            }    
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string kq = GiaiPhuongTrinhBac2(2, 5, -7);
            Console.WriteLine(kq);
            Console.ReadLine();
        }
    }
}
