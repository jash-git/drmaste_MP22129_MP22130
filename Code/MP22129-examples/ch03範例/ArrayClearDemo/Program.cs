using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClearDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ary = { 1, 2, 3, 4, 5 };
            Array.Clear(ary, 1, 3);
            foreach (int i in ary)
                Console.Write($"{i}\t");
            Console.Read();
        }
    }
}
