using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] subjects = new string[3][];
            subjects[0]= new string[] { "基本電學", "基礎電子學", "資訊技術實習" };
            subjects[1] = new string[] { "電子學", "數位邏輯", "數位邏輯進階", "程式語言實習" };
            subjects[2] = new string[] { "電子電路", "專題製作", "基本電路學", "微電腦結構", 
                                         "電腦網路實習", "邏輯設計實習" , "微電腦單晶片實習",
                                         "工業電子實習", "介面技術實習", "電子儀表量測"};
            Console.WriteLine("*** 資訊科課程查詢  *** (輸入0 停止)");
            while (true)
            {
                Console.Write("請輸入1~3查詢該年級的課程：");
                int year = int.Parse(Console.ReadLine());
                if (year >=1 && year<= subjects.Length)
                {
                    Console.WriteLine($"資訊科{year}年級課程：");
                    foreach (string s in subjects[year - 1])
                        Console.WriteLine($"{s}");
                }
                else
                {
                    Console.WriteLine("結束查詢");
                    break;
                }

            }
            Console.Read();
        }
    }
}
