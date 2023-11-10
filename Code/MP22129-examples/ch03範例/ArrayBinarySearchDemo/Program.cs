using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBinarySearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 57, 98, 82, 64, 95, 100, 35, 77 };
            Array.Sort(score);
            int index = Array.BinarySearch(score, 64);
            Console.WriteLine($"陣列元素值64在註標 {index}");
            Console.Read();
        }
    }
}
