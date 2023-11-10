using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 1; k <= 20; k++)
            {
                if (k % 3 == 0)
                    continue;
                Console.Write($"{k}\t");
            }
            Console.Read();
        }
    }
}
