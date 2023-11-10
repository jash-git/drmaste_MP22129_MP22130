using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)      // 外層迴圈控制列數
            {
                for (int j = 1; j <= i; j++)  // 內層迴圈控制顯示字數
                {
                    Console.Write($"{j} ");
                }
                Console.Write("\n");      // 換行
            }
            Console.Read();
        }
    }
}
