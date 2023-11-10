using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (n = 0; n < 6; n++)
                Console.WriteLine($" n = {n} ");
            Console.WriteLine($" n = {n} ");
            for (int m = 0; m < 6; m++)
                Console.WriteLine($" m = {m} ");
            Console.WriteLine($" m = {m} ");
            Console.Read();
        }
    }
}
