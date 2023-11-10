using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, max;
            Console.Write("1. 請輸入第 1 個整數：");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("2. 請輸入第 2 個整數：");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("3. 請輸入第 3 個整數：");
            n3 = int.Parse(Console.ReadLine());
            if (n1 < n2)
            {
                max = n2;
                if (n2 < n3) max = n3;
            }
            else
            {
                max = n1;
                if (n1 < n3) max = n3;
            }
            //max = n1<n2 ? (n2<n3 ? n3:n2):(n1<n3 ? n3:n1);
            Console.WriteLine($"{n1}、{n2}、{n3} 三數的最大值為：{max}");
            Console.Read();
        }
    }
}
