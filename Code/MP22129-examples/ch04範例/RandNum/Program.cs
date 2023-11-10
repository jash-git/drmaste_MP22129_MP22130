using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranObj = new Random();  // 建立名稱為ranObj亂數物件實體
            int ranNum;
            for (int i = 1; i <= 3; i++)
            {
                ranNum = ranObj.Next(1, 50);
                Console.WriteLine($"第 {i} 個亂數 : {ranNum}");
            }
            Console.Read();
        }
    }
}
