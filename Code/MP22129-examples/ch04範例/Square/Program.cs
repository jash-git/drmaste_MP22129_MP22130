using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();          // 建立Class1類別的物件obj
            Console.Write(" 1. 請輸入一個整數 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($" 2. 整數 {num1} 的平方為 :{obj.Squart(num1)}");
            Console.Read();
        }
    }
    public class Class1         //建立Class1類別
    {
        public int Squart(int n1)  //未加ststic無法直接呼叫必須先建物件實體
        {
            return n1*n1;       // 傳回值
        }
    }
}
