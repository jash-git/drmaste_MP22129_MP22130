using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, sum = 0;
            for (k = 1; k <= 10; k++)
            {
                sum += k;
                if (sum > 30)
                    break;
                Console.Write($"{k}\t");
            }
            Console.Write($"\nk= {k} 時總和超過30");
            Console.Read();
        }
    }
}
