using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] data= {0.0};
            int num = 0;
            double money;
            Console.WriteLine("*** 計算累計金額  *** (輸入0 停止)");
            while(true)
            {
                Console.Write("請輸入金額：");
                money = double.Parse(Console.ReadLine());
                if (money > 0)
                {
                    num++;	//陣列元素數量加1
                    Array.Resize(ref data, num);	//重設陣列大小
                    data[num - 1] = money;	//輸入值存入最後一個元素
                }
                else
                    break;
            }
            double sum = 0; //預設總金額為0
            foreach(double d in data)
                sum += d;	// 累加輸入金額
            Console.WriteLine($"輸入金額合計：{sum} 元");
            Console.Read();
        }
    }
}
