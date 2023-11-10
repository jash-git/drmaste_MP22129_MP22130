using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 2;
            switch (month)
            {
                case 3:
                case 4:
                case 5:     // 3~5月皆為春天
                    Console.WriteLine("春天");
                    break;  //離開switch
                case 6:
                case 7:
                case 8:     //6~8月皆為夏天
                    Console.WriteLine("夏天");
                    break;
                case 9:
                case 10:
                case 11:    //9~11月皆為秋天
                    Console.WriteLine("秋天");
                    break;
                case 12:
                case 1:
                case 2:     //12,1,2月皆為冬天
                    Console.WriteLine("冬天");
                    break;
                default:
                    Console.WriteLine("數值錯誤 ! ");
                    break;
            }
            Console.Read();
        }
    }
}
