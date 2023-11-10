using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //例1
            int[] num = { 12, 45, 76, -3, 48, 93 };
            Array.Sort(num);
            foreach(int n in num)
            {
                Console.Write($"{n}\t");
            }
            Console.WriteLine("\n");
            //例2
            int[] score = new int[] { 90, 60, 50, 70, 80 };
            string[] name = new string[] { "Mary", "Jack", "Tom", "David", "Grace" };
            Array.Sort(score, name);
            for(int i=0; i < score.Length; i++)
            {
                Console.WriteLine($"姓名：{name[i]}\t成績：{score[i]} 分");
            }
            Console.Read();
        }
    }
}
