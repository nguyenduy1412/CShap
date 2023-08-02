using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPTB2
{
    internal class Program
    {
        static string PTB2(double a,double b,double c)
        {
            if (a == 0)
                return "Không phải phương trình bậc 2";
            else
            {
                string str = "";
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    str="Phương trình vô nghiệm";
                else if (delta == 0)
                    str = (b == 0) ? "Phương trình có nghiệm kép x1=x2=0" : "Phương trình có nghiệm kép x1=x2=" + -b / (2 * a);
                else
                {
                    str="Phương trình có 2 nghiệm phân bịệt x1="+(-b+Math.Sqrt(delta))/(2*a)+"và x2="+(-b - Math.Sqrt(delta)) / (2 * a);
                }
                return str;
            }    
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(PTB2(1, -4,4));
            Console.ReadLine();

        }
    }
}
