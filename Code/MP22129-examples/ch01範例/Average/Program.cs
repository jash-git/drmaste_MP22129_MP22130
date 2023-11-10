using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入第1個整數：");
            int x = int.Parse(Console.ReadLine());  // 整數x初值由使用者輸入
            Console.Write("請輸入第2個整數：");
            int y = int.Parse(Console.ReadLine());  // 整數y初值由使用者輸入
            float avg = (float)(x + y) / 2; 
            Console.WriteLine($"{x} 和 {y} 的平均值為：{avg}");
            Console.Write("按 <任意> 鍵結束程式");
            Console.Read();  // 待使用者按鍵
        }
    }
}
