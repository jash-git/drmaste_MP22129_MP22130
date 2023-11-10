using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByRef
{
    class Program
    {
        private static void Swap(ref int a, ref int b)
        {
            int temp = a; a = b;b = temp;
        }
        // ----------------------------------------------------------------------------
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine($"1. 交換前第一個數： {num1} 、第二個數：{num2}");
            Swap(ref num1, ref num2);
            Console.WriteLine($"2. 交換後第一個數： {num1} 、第二個數：{num2}");
            Console.Read();
        }
    }
}
