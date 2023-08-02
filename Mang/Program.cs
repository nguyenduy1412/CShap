using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    internal class Program
    {
        /// <summary>
        /// Tạo 1 mảng có n phần từ sau đó nhập giá trị ngẫu nhiên cho các pt
        /// Xuất các giá trị
        /// Đảo ngược mảng
        /// Sắp xếp
        /// Tìm kiếm
        /// Tính tổng
        /// 
        /// </summary>
        static void Mang1Chieu()
        {
            Console.WriteLine("Mời bạn nhập số phần từ trong mảng:");
            int n=int.Parse(Console.ReadLine());
            int[] M=new int[n];
            Random rd= new Random();
            for(int i=0; i<n; i++)
            {
                M[i]=rd.Next(100);
            }
            Console.WriteLine("Gía trị trong mảng là");
            for(int i=0; i<M.Length ; i++)
            {
                Console.Write(M[i]+"   ");
            }
            Array.Reverse(M);
            Console.WriteLine("\nMảng sau khi đảo chiều là");
            foreach(int i in M)
                Console.Write(i+"   ");
            Array.Sort(M);
            Console.WriteLine("\nMảng sau khi sắp xếp là");
            foreach (int i in M)
                Console.Write(i + "   ");
            int sum = 0;
            foreach(int  x in M)
                sum+= x;
            Console.WriteLine("\nTổng mảng là " + sum);
            //tìm kiếm mảng
            Console.WriteLine("Mời bạn nhập vào số muốn tìm");
            int k=int.Parse(Console.ReadLine());
            int kq=Array.BinarySearch(M, k);
            if (kq <0)
            {
                Console.WriteLine("Không tìm thấy {0} trong màng", k);
            }
            else
                Console.WriteLine("Tìm thấy {0} tại vị trí thứ {1}",k,kq);

        }
        static void Mang2Chieu()
        {
            Console.WriteLine("Mời bạn nhập vào số dòng");
            int dong=int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Mời bạn nhập vào số cột");
            int cot = int.Parse(Console.ReadLine());
            int[,] M = new int[dong,cot];
            Random rd=new Random();
            for(int i=0; i<M.GetLength(0); i++) 
            { 
                for(int j=0;j<M.GetLength(1);j++)
                {
                    M[i, j] = rd.Next(100);
                }
            }
            Console.WriteLine("Mảng 2 chiều là");
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(M[i, j]+"    ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //Mang1Chieu();
            Mang2Chieu();
            Console.ReadLine();
        }
    }
}
