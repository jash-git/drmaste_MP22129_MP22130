using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "深夜食堂", "我的老台北", "暮光之城","貓非貓",
                "看見雪的日子", "暮光之城", "以我之名", "撒哈拉歲月","傾城之戀",
                "親愛的艾德華", "失眠的人", "暮光之城", "貓非貓", "看見雪的日子"};
            Array.Sort(books);
            Console.Write("請輸入查詢的書名：");
            string search = Console.ReadLine();
            int index = Array.BinarySearch(books, search);
            if (index < 0)
                Console.WriteLine($"您查詢的「{search}」不在書單中。");
            else
            {
                index=Array.IndexOf(books,search);  //找到第一本書的註標值
                int num = 1;    //書本數量
                for (int i = index + 1; i < books.Length; i++)  //由下一個註標找起
                {
                    if (Array.IndexOf(books, search, i,1) != -1)//找到時
                        num++;  //本數加1
                    else
                        break;
                }
                Console.WriteLine($"您查詢的「{search}」共有 {num} 本。");
            }
            Console.Read();
        }
    }
}
