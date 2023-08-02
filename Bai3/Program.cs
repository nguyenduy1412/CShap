using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            int month;
            Console.WriteLine("Nhập tháng:");
            month = int.Parse(Console.ReadLine());
            int day;
            switch(month) 
            {
                case 2:
                    Console.WriteLine("Nhập năm:");
                    int year;
                    year = int.Parse(Console.ReadLine());
                    day = (year % 400 == 0 || year % 4 == 0 && year % 10 != 0) ? 29 : 28;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day= 30;
                    break;
                default:
                    day = 0;
                    break;
            }
            Console.WriteLine("tháng {0} có {1} ngày ",month,day);
            Console.ReadLine();
        }
    }
}
