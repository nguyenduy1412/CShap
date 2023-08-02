using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void HocList()
        {
            //cấp phát bộ nhớ
            List<string> ds = new List<string>();
            //thêm 1 phần tử
            ds.Add("An");
            ds.Add("Bình");
            ds.Add("Hạnh");
            ds.Add("Phúc");
            ds.Add("An");
            ds.Insert(2, "Châu");
            ds.Remove("Bình");
            ds.RemoveAt(0);
            Console.WriteLine("Danh sách các phần tử trong list là ");
            for(int i=0;i<ds.Count;i++)
            {
                string v = ds[i];
                Console.WriteLine(v);
            }

        }
        static void HocList2()
        {
            List<int> ds= new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                ds.Add(rnd.Next(100));
            }
            Console.WriteLine("Các phần tử trong danh sách gốc là");
            foreach(int x in ds)
                Console.Write(x+"\t");
            int k;
            Console.WriteLine("\nMời bạn nhập số cần tìm");
            k=int.Parse(Console.ReadLine());
            int kq = ds.IndexOf(k);
            if (kq < 0)
                Console.WriteLine("không tìm thấy trong ds");
            else
                Console.WriteLine("Tìm thấy {0} tại vị trí thứ {1}", k, kq);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //HocList();
            HocList2();
            Console.ReadLine();
        }
    }
}
