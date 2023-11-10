using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casher
{
    class CNumber : CFruit   // CNumber繼承CFruit類別
    {
        public int Number { get; set; }    // Number為數量屬性
        public CNumber(int number, double price)
        {
            Number = number;
            Price = price;
        }
        public override double spend()   // 覆寫父類別的spend()方法 
        {
            return Number * Price;
        }
    }
}
