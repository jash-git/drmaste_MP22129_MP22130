using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入學生人數：");
            int num = int.Parse(Console.ReadLine());    //記錄學生人數
            int[] score = new int[num];
            for(int i = 0; i < num; i++)
            {
                Console.Write($"請輸入 {i + 1} 號的成績：");
                score[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n輸入的成績為：");
            int no = 0;         //記錄學生座號
            double sum = 0;     //紀錄成績總和
            foreach(int s in score)
            {
                Console.WriteLine($"{++no} 號成績：{s} 分");
                sum += s;   //成績總和累加
            }
            Console.WriteLine($"學生平均分數：{sum/num} 分");
            Console.Read();
        }
    }
}
