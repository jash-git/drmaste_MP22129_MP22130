using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double
{
    class Program
    {
        private static int NumDouble(int num)  // 定義為私有靜態方法，傳回整數值
        //private int NumDouble(int num)  // 定義為私有非靜態方法，傳回整數值
        {
            return num*2;   // 傳回值
        }
        // ---------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            Console.Write(" 1. 請輸入一個正整數 : ");
            int num1 = int.Parse(Console.ReadLine());
            //Program p = new Program();   // 建立Program類別的p物件
            int num2 = NumDouble(num1);    // 呼叫同類別定義的NumDouble私有靜態方法
            //int num2 = p.NumDouble(num1);    // 呼叫同類別定義的NumDouble私有非靜態方法
            Console.WriteLine($"\n 2. 兩倍結果 : {num2}");
            Console.Read();
        }
    }
}
