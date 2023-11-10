using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, -13, 30, 15, -8 };
            Console.WriteLine("排序前陣列元素值");
            for(int i=0; i < a.Length; i++)
            {
                Console.Write($"a[{i}]={a[i]}  ");
            }
            int temp;
            for(int x=1; x < a.Length; x++)	//x表第幾次排序
            {
                for(int y = 0; y < (a.Length - x); y++)	//由第1個元素開始比較
                {
                    if (a[y] > a[y + 1])	//若前面元素值較大就交換
                    {
                        temp = a[y];
                        a[y] = a[y + 1];
                        a[y + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n排序後陣列元素值");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}]={a[i]}  ");
            }
            Console.Read();
        }
    }
}
