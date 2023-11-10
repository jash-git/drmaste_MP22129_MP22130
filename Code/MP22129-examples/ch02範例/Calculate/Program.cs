using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1;
            Console.Write("請輸入第1個數：");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("請輸入第2個數(不能為0)：");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("請輸入運算子(+、-、*、/)：");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("運算子錯誤");
                    break;
            }
            Console.Read();
        }
    }
}
