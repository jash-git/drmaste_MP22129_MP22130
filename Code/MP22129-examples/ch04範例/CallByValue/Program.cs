using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue
{
    class Program
    {
        private static void PassValue(int x, int y)
        {
            x = x + 5;
            y = y + 10;
            Console.WriteLine($" 2. 呼叫中 : x =  {x}  y = {y}");
        }
        // ----------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            int a = 1;
            int b = 10;
            Console.WriteLine("======  傳值呼叫  ======");
            Console.WriteLine($" 1. 呼叫前 : a =  {a}  b = {b}");
            PassValue(a, b);
            Console.WriteLine($" 3. 呼叫後 : a =  {a}  b = {b}");
            Console.Read();
        }
    }
}
