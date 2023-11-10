using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
                num[i] = i + 1;  //逐一設定num陣列元素值
            for (int i = 0; i < num.Length; i++)
                Console.Write($" num[{i}]={num[i]}  ");
            Console.Read();
        }
    }
}
