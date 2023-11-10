using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AryMaxAvg
{
    class Program
    {
        private static int AryMax(ref int[] tAry)
        {
            Array.Sort(tAry);   //遞增排序
            return (tAry[tAry.Length - 1]);   // 傳回最大值
        }
        // -------------------------------------------------------------------------------------------
        private static float AryAvg(ref int[] tAry)
        {
            int sum = 0;
            foreach (int n in tAry)
                sum += n;
            return (float)sum / (tAry.Length);
        }
        // -------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            int[] numAry = new int[5];
            for (int i = 0; i < numAry.Length; i++)
            {
                Console.Write($"{i + 1}. 請輸入第 {i + 1} 個整數 : ");
                numAry[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($" 最大數為 ：{AryMax(ref numAry)}");
            Console.WriteLine($" 平均值為 ：{AryAvg(ref numAry):F2}");
            Console.Read();
        }
    }
}
