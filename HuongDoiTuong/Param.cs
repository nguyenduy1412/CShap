using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong
{
    public class Param
    {
        public int Sum(params int[] arr)
        {
            int s = 0;
            foreach (int x in arr)
                s+= x;
            return s;
        }
    }
}
