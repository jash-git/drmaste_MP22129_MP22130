using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        private static int Factorial(int num)
        {
            if (num == 1)
                return 1;   // 結束遞迴呼叫
            else
                return num * Factorial(num - 1);    // 遞迴呼叫
        }
        // ---------------------------------------------------------
        static void Main(string[] args)
        {
            Console.Write(" 請輸入階乘值(1 ~ 10) : ");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n {no}! = {Factorial(no)}");
            Console.Read();
        }
    }
}
