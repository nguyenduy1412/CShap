using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamedoanso
{
    internal class Program
    {
        static int soNgauNhien()
        {
            Random rd = new Random();
            return rd.Next(501);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            int ketqua=soNgauNhien();
            int i = 0;
            while (i <= 7)
            {
                Console.WriteLine("Bạn đoán lần thứ {0}",i+1);
                int n = int.Parse(Console.ReadLine());
                i++;
                if(n == ketqua)
                {
                    Console.WriteLine("Bạn đã đoán đúng số mà máy tính đưa ra");
                    break;
                } 
                else
                {
                    string str= (n < ketqua) ? "Số bạn đoán nhỏ hơn số máy tính đưa ra" : "Số bạn đoán lớn hơn số máy tính đưa ra";
                    Console.WriteLine(str);
                    if (i == 7)
                    {
                        Console.WriteLine("Game over");
                        Console.WriteLine("Số của máy là " + ketqua);
                        break;
                    }    
                    Console.WriteLine("Bạn có muốn tiếp tục hay không");
                    string traloi=Console.ReadLine();
                    if(traloi!="có")
                        break;
                }    
            }
            Console.ReadLine();
        }
    }
}
