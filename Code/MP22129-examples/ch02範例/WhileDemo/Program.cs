using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, sum = 0;
            while (sum <= 100)
            {
                i++;
                sum += i;
            }
            Console.Write($"1+2+... {i} = {sum}");
            Console.Read();
        }
    }
}
