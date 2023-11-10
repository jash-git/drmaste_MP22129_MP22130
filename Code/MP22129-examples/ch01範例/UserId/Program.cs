using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserId
{
    class Program
    {
        static void Main(string[] args)
        {
            string userId;      // 宣告一個名稱為userId的字串變數
            Console.Write("請輸入您的帳號：");  // 顯示輸入提示訊息
            userId= Console.ReadLine();         // 將輸入帳號存入userId變數中
            Console.WriteLine("您的帳號是{0}",userId);    // 將變數內容顯示
            Console.Write("請按Enter鍵結束");   // 顯示輸出提示訊息
            Console.Read();     // 等待使用者按鍵，以觀看輸出結果
        }
    }
}
