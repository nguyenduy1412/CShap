using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuoi
{
    internal class Program
    {
        //Nhập vào 1 chuỗi sau đó
        //Đếm xem chuỗi có bao nhiêu in Hoa, in thường, số
        //Đếm số khoảng trắng trong chuỗi
        static void XuLyChuoi1()
        {
            string s = "";
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi:");
            s=Console.ReadLine();
            int demInHoa = 0, demInThuong = 0, demSo = 0,demKT=0;
            char[] arr=s.ToCharArray();
            for(int i=0;i<arr.Length;i++)
            {
                if (char.IsLower(arr[i]))
                    demInThuong++;
                if (char.IsUpper(arr[i]))
                    demInHoa++;
                if (char.IsDigit(arr[i])) 
                    demSo++;
                if (char.IsWhiteSpace(arr[i])) 
                    demKT++;
            }
            Console.WriteLine($"Có {demInThuong} ký tự in thường");
            Console.WriteLine($"Có {demInHoa} ký tự in hoa");
            Console.WriteLine($"Có {demSo} ký tự so");
            Console.WriteLine($"Có {demKT} ký tự Khoang trang");

        }
        static void XuLyChuoi2()
        {
            string s = "";
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi:");
            s = Console.ReadLine();
            int demInHoa = 0, demInThuong = 0, demSo = 0, demKT = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char kt = s[i];
                if (char.IsLower(kt))
                    demInThuong++;
                if (char.IsUpper(kt))
                    demInHoa++;
                if (char.IsDigit(kt))
                    demSo++;
                if (char.IsWhiteSpace(kt))
                    demKT++;
            }
            Console.WriteLine($"Có {demInThuong} ký tự in thường");
            Console.WriteLine($"Có {demInHoa} ký tự in hoa");
            Console.WriteLine($"Có {demSo} ký tự so");
            Console.WriteLine($"Có {demKT} ký tự Khoang trang");

        }
        static void XuLyChuoi3()
        {
            string s;
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi:");
            s=Console.ReadLine();
            Console.WriteLine("Mời bạn nhập vào chuỗi tiếp theo:");
            string s2=Console.ReadLine();
            int kq=s.ToLower().CompareTo(s2.ToLower());
            if (kq == 0)
                Console.WriteLine("s và s2 giống nhau");
            else if (kq < 0)
            {
                Console.WriteLine("s < s2 ");
            }
            else
                Console.WriteLine("s > s2 ");
        }
        static void XuLyChuoi4() 
        {
            string s = string.Format("{0:dd//MM//yyyy HH:mm:ss}", DateTime.Now);
            Console.WriteLine(s);
        }
        static void XuLyChuoi5()
        {
            string s = "D:/baihat/nhactrinh/dem thay ta la thac do.mp3";
            //hãy tìm vị trí đầu tiên của ký tự/
            int vt=s.IndexOf("/");
            Console.WriteLine("tìm thấy ký tự / ở vị trí thứ {0}", vt);
            int vt2 = s.LastIndexOf("/");
            Console.WriteLine("tìm thấy ký tự / ở vị trí thứ {0}", vt2);
        }
        //Cho 1 chuỗi gốc yêu cầu xóa các khoảng trắng dư thừa bên trái, phải chuỗi, các từ
        //cách nhau bởi 1 khoảng trắng, ký tự đầu tiên viết Hoa
        static void ToiUuChuoi()
        {
            Console.WriteLine("Mời bạn nhập vào 1 tên:");
            string ten=Console.ReadLine();
            Console.WriteLine("Chuỗi gốc bạn nhập:"+ten);
            ten = ten.Trim();
            string[] arr =ten.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            ten = "";
            for(int i=0;i<arr.Length;i++)
            {
                string word = arr[i];
                word=word.ToLower();
                char[] arrWord = word.ToCharArray();
                arrWord[0] = char.ToUpper(arrWord[0]);
                string newWord = new string(arrWord);
                ten += newWord + " ";
            }
            ten=ten.Trim();
            Console.WriteLine("Chuỗi sau khi tối ưu :"+ten);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //XuLyChuoi1();
            //XuLyChuoi2();
            //XuLyChuoi3();
            //XuLyChuoi4();
            //XuLyChuoi5();
            ToiUuChuoi();
            Console.ReadLine();

        }
    }
}
