using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 70, 90, 80, 60, 90, 100 };
            int index = Array.IndexOf(score, 90);
            Console.WriteLine($"index={index}");
            index = Array.IndexOf(score, 90, 2);
            Console.WriteLine($"index={index}");
            Console.Read();
        }
    }
}
