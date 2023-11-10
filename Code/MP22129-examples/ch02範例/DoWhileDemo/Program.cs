using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("請輸入1到6之間的整數：");
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 6);
            Console.WriteLine($"輸入的整數 = {num}");
            Console.Read();
        }
    }
}
