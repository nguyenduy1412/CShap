using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuDien
{
    internal class Program
    {
        static Dictionary<string,string> dic=new Dictionary<string,string>();

        private static void menu()
        {
            Console.WriteLine("1.Tạo từ mới");
            Console.WriteLine("2.Sửa từ");
            Console.WriteLine("3.Tra cứu");
            Console.WriteLine("4.Xóa từ");
            Console.WriteLine("5.Thay đổi cấu trúc để làm bổ sung tra cứu từ đồng nghĩa");
            Console.WriteLine("Bạn chọn chức năng nào");
            try
            {
                int cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        Console.WriteLine("Nhập số lượng từ mà bạn muốn thêm");
                        int n= int.Parse(Console.ReadLine());
                        for(int i = 0; i < n;i++)
                        TaoTuMoi();
                        break;
                    case 2:
                        SuaTu();
                        break;
                    case 3:
                        TraCuu();
                        break;
                    case 4:
                        XoaTu();
                        break;
                        case 5:
                        TuDongNghia();
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng");
                        break;
                }
            }catch(Exception ex) 
            { 
                Console.WriteLine("Lỗi"+ex.Message);                
            }


        }

        private static void TuDongNghia()
        {

            Console.WriteLine("Mời bạn nhập từ cần tra cứu");
            string ta=Console.ReadLine();
            if(dic.ContainsKey(ta))
            {
                List<string> ds = new List<string>();
                string tv = dic[ta];
                foreach (KeyValuePair<string, string> iteam in dic)
                {
                    if(iteam.Value==tv && iteam.Key!=ta)
                    {
                        string dn=iteam.Key;
                        ds.Add(dn);
                    }    
                }
                Console.WriteLine("Các từ đồng nghĩa {0} là", ta);
                foreach(string x in ds)
                    Console.WriteLine(x);
            }   
            else
            {
                Console.WriteLine("Không có từ {0} trong từ điển ", ta);
            }    
        }

        private static void XoaTu()
        {
            Console.WriteLine("Mời bạn nhập vào từ muốn xóa:");
            string ta=Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                dic.Remove(ta);
                Console.WriteLine("Xóa thành công từ " + ta);
            }
            else
                Console.WriteLine("Không tìm thấy từ " + ta);
        }

        private static void TraCuu()
        {
            Console.WriteLine("Mời bạn nhập vào từ tiếng anh");
            string ta=Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                string tv = dic[ta];
                Console.WriteLine("Nghĩa của {0} là {1}", ta, tv);
            }
            else
                Console.WriteLine("Từ điển chưa cập nhật {0}", ta);
        }

        private static void SuaTu()
        {
            Console.WriteLine("Nhập vào tiếng anh để sửa nghĩa");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta) == false)
                Console.WriteLine("Không tìm thấy {0} để sửa", ta);
            else
            {
                Console.WriteLine("Mời bạn nhập lại nghĩa tiếng việt");
                string tv=Console.ReadLine();
                dic[ta] = tv;
            }
        }

        private static void TaoTuMoi()
        {
            Console.WriteLine("Mời bạn nhập vào từ tiếng anh");
            string ta=Console.ReadLine();
            if(dic.ContainsKey(ta))
            {
                Console.WriteLine("Từ {0} đã tồn tại", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập vào nghĩa tiếng việt");
                string tv=Console.ReadLine();
                dic.Add(ta, tv);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.InputEncoding= Encoding.UTF8;
            while (true)
            {
                menu();
                Console.WriteLine("Bạn có tiếp tục sử dụng từ điển không?(c/k)");
                string s=Console.ReadLine();
                if (s == "k")
                    break;
            }
            Console.WriteLine("BYE BYE");
            Console.ReadLine();
        }
    }
}
