using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //例1
            int a = 10;
            int abs;
            abs = a < 0 ? -a : a;    //使用三元運算子
            Console.WriteLine($"a = {a} , abs = {abs} ");
            a = -10;
            if (a < 0)              //使用if選擇敘述
                abs = -a;
            else
                abs = a;
            Console.WriteLine($"a = {a} , abs = {abs} ");

            //例2
            int score = 75;
            string ok;
            ok = score >= 60 ? "及格" : score < 50 ? "死當" : "補考";
            Console.WriteLine($"score = {score} , ok = {ok} ");
            score = 55;
            ok = (score >= 60 ? "及格" : (score < 50 ? "死當" : "補考"));
            Console.WriteLine($"score = {score} , ok = {ok} ");
            score = 45;
            ok = (score >= 60 ? "及格" : (score < 50 ? "死當" : "補考"));
            Console.WriteLine($"score = {score} , ok = {ok} ");
            Console.Read();
        }
    }
}
