using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //例1
            int score = 75;
            string grade = "";
            int count = 0;
            if (score >= 60)
            {
                grade = "及格";
                count++;
            }
            Console.WriteLine($"score= {score},grade= {grade}, count= {count} ");

            //例2
            int a = 10;
            if (a < 0)
                a = -a;
            Console.WriteLine($"10的絕對值= {a} ");
            a = -10;
            if (a < 0) a = -a;      //單行敘述
            Console.WriteLine($"-10的絕對值= {a} ");

            //例3
            int point = 465;
            Boolean pass = false;
            if (point >= 1000)
                pass = true;
            Console.WriteLine($"point= {point}, pass= {pass} ");
            point = 1075;
            if (point >= 1000) pass = true;      //單行敘述
            Console.WriteLine($"point= {point}, pass= {pass} ");
            Console.Read();
        }
    }
}
