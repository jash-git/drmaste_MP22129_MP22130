using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. 請輸入公里數(整數)：");
            int km = int.Parse(Console.ReadLine());
            if (km < 10) km = 10;		//最低里程為10公里
            Console.Write("2. 請輸入車種(英文)A.自強號 B.莒光號 C.區間車：");
            string kind = Console.ReadLine();
            double price;	//車種費率
            string car;	    //車種名稱
            if (kind == "A" || kind == "a")
            {
                price = 2.27;
                car = "自強號";
            }
            else if (kind == "B" || kind == "b")
            {
                price = 1.75;
                car = "莒光號";
            }
            else
            {
                price = 1.46;
                car = "區間車";
            }
            Console.WriteLine($"\n{car}行駛{km}公里票價為：{price*km:f0}元");
            Console.Read();
        }
    }
}
