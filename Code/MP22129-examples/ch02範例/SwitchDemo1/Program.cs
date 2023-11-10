using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            switch (num)
            {
                case 1:
                    Console.WriteLine("一");
                    break;
                case 2:
                    Console.WriteLine("二");
                    break;
                case 3:
                    Console.WriteLine("三");
                    break;
                case 4:
                    Console.WriteLine("四");
                    break;
                case 5:
                    Console.WriteLine("五");
                    break;
                case 6:
                    Console.WriteLine("六");
                    break;
                case 7:
                    Console.WriteLine("七");
                    break;
                case 8:
                    Console.WriteLine("八");
                    break;
                case 9:
                    Console.WriteLine("九");
                    break;
                case 10:
                    Console.WriteLine("十");
                    break;
                default:
                    Console.WriteLine("數值錯誤 ! ");
                    break;
            }
            Console.Read();
        }
    }
}
