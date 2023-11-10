using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            while (true)
            {
                try
                {
                    Console.Write("請輸入分數(0 ~ 100 的整數)：");
                    score = int.Parse(Console.ReadLine());
                    if (score < 0 || score > 100)
                    {
                        throw new InvalidCastException();  // 輸入錯誤跳至catch敘述
                    }
                    Console.WriteLine($"你輸入的分數是 {score}");
                    break;
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("分數只能是0 ~ 100 的整數 !\a");
                }
            }
            Console.Read();
        }
    }
}
