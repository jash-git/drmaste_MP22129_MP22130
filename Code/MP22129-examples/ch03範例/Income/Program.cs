using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "三月,四月,五月,六月,98637,182754,276189,249745";
            string[] dAry = data.Split(',');
            string[] title=new string[4];
            Array.Copy(dAry, title, 4);
            string[] income = new string[4];
            Array.Copy(dAry, 4, income,0, 4);
            double total = 0;
            for(int i = 0; i < title.Length; i++)
            {
                Console.WriteLine($"{title[i]}營業額為 {income[i]} 元");
                total += double.Parse(income[i]);
            }
            Console.WriteLine($"營業額合計為 {total} 元");
            Console.Read();
        }
    }
}
