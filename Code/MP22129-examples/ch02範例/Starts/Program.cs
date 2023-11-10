using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starts
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 1;
            Console.Write("請為餐廳評等(1 ~ 10 )：");
            score = int.Parse(Console.ReadLine());
            if (score < 1)
            {
                score = 1;
            }
            else if (score > 10)
            {
                score = 10;
            }
            Console.Write("\n餐廳評等為：");
            for (int s = 1; s <= score; s++)
            {
                Console.Write("★ ");
            }
            Console.Read();
        }
    }
}
