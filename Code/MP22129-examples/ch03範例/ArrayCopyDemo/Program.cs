using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //例1
            int[] ary1 = { 1, 2, 3, 4, 5 };
            int[] ary2 = { 10, 20, 30, 40, 50, 60 };
            Array.Copy(ary1, ary2, 3);
            foreach (int a in ary2)
                Console.Write($"{a}\t");
            Console.WriteLine();
            //例2
            int[] ary3 = { 1, 2, 3, 4, 5 };
            int[] ary4 = { 10, 20, 30, 40, 50, 60 };
            Array.Copy(ary3, 1, ary4, 2, 3);
            foreach (int a in ary4)
                Console.Write($"{a}\t");
            Console.Read();
        }
    }
}
