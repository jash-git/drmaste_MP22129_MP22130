using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberVar
{
    class Program
    {
        private static int n = 5; // 宣告n為Program類別私有的欄位資料成員
        // -------------------------------------------
        private static void Add()
        {
            n += 5;
            Console.WriteLine(" n = {0} ", n);   // 顯示n=20
        }
        // -------------------------------------------
        static void Main(string[] args)
        {
            n += 10;
            Console.WriteLine(" n = {0} ", n);  // 顯示n=15(5+10)
            Add();  //呼叫Add()方法後n=20
            n += 20;
            Console.WriteLine($" n = {n} ");    // 顯示n=40(20+20)
            Console.Read();
        }
    }
}
