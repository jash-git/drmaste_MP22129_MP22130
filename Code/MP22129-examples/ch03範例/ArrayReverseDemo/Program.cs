using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 98, 78, 85, 64 };
            Array.Sort(score);
            foreach(int s in score)
            {
                Console.Write($"{s}\t");
            }
            Console.WriteLine("\n");
            Array.Reverse(score);
            foreach (int s in score)
            {
                Console.Write($"{s}\t");
            }
            Console.Read();
        }
    }
}
