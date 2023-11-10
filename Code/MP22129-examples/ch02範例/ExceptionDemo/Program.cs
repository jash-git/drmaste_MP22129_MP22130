using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            try
            {
                Console.Write("\n 1. 輸入num1 = ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("\n 2. 輸入 num2 = ");
                num2 = int.Parse(Console.ReadLine());
                num3 = num1 / num2;
                Console.WriteLine($"\n 3. 結果: {num1}/{num2} = {num3}\n");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\n 4. 除數不得為 0 !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n 5. {ex.Message} \n");
            }
            Console.Read();
        }
    }
}
