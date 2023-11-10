using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 20, (i) => {
                Console.Write("{0}, ", i);
            });
            Console.ReadKey();
        }
    }
}
