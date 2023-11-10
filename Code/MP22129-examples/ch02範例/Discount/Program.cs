using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;      //實付金額
            Console.Write("請輸入消費金額：");
            int price = int.Parse(Console.ReadLine());  //消費金額
            //if (price >= 1000)    //若消費金額大於等於1000元
            //{
            //    total = (int)(price * 0.95);    //設total值為price打95折
            //}
            //else    //若消費金額小於1000元
            //{
            //    total = price;
            //}
            total= price >= 1000 ? (int)(price * 0.95) : price;
            Console.WriteLine($"消費金額{price}元，實付{total}元。");
            Console.Read();
        }
    }
}
