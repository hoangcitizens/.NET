using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2c_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo 1 Dictionary đơn giản và thêm vào 3 phần tử.
            Dictionary<string, string> MyDic4 = new Dictionary<string,
            string>();
            MyDic4.Add("FE", "Free Education");
            MyDic4.Add("K", "Kteam");
            MyDic4.Add("HK", "HowKteam");
            // Duyệt qua các phần tử trong Dictionary và in ra màn hình cặp Key -Value của mỗi phần tử được duyệt.
                foreach (KeyValuePair<string, string> item in MyDic4)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
    }
}
