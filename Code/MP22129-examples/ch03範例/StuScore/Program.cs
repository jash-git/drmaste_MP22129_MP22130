using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuScore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[,] score = { { 80, 75, 60 }, { 65, 67, 62 }, { 100, 93, 91 }, { 98, 25, 50 }, { 83, 82, 87 } };
            Console.Write("輸入座號(1-5)：");
            int no = int.Parse(Console.ReadLine());
            if (no >= 1 && no <= 5)
            {
                Console.WriteLine($"1. 姓   名 : {name[no - 1]}");
                Console.WriteLine($"2. 電腦概論: {score[no - 1, 0]}");
                Console.WriteLine($"3. 程式設計: {score[no - 1, 1]}");
                Console.WriteLine($"4. 動畫設計: {score[no - 1, 2]}");
            }
            else
                Console.WriteLine(" ... 座號超出範圍 ...");
            Console.Read();

        }
    }
}
