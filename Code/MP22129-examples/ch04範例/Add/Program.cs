using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" 1. 請輸入第一個整數 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write(" 2. 請輸入第二個整數 : ");
            int num2 = int.Parse(Console.ReadLine());
            //int num2 = Class1.Add(num1);   // 呼叫不同類別的Add靜態方法
            Console.WriteLine($" 3. 相加結果 : {Class1.Add(num1,num2)} ");
            Console.Read();
        }
    }
    public class Class1       // 建立Class1類別
    {
        public static int Add(int n1, int n2)  // Class1類別內的Add方法
        {
            return n1 + n2;      // 傳回值
        }
    }
}
