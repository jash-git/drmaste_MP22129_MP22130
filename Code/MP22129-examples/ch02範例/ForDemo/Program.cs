using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //例1
            Console.WriteLine("例 1");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i}\t");
            }
            //例2
            Console.WriteLine("\n例 2");
            for (int j = 10; j >= 2; j -= 2)
            {
                Console.Write($"{j}\t");
            }
            //例3
            Console.WriteLine("\n例 3");
            int x, y;
            for (x = 1, y = 1; x <= 7 && y <= 15; x += 2, y += 3)
            {
                Console.Write($"{x} {y}\t");
            }
            //例4
            Console.WriteLine("\n例 4");
            int a, b;
            for (a = 1, b = 1; a <= 10 || b <= 10; a++, b += 2)
            {
                if (a * b > 50)
                    break;
                Console.Write($"{a}x{b}={a * b}\t");
            }
            Console.Read();
        }
    }
}
