using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casher
{
    class CWeight : CFruit    // CWeight繼承CFruit類別
    {
        public double Weight { get; set; }   // Weight為重量屬性
        public CWeight(double weight, double price)
        {
            Weight = weight;
            Price = price;
        }
        public override double spend()   // 覆寫父類別的spend()方法
        {
            return Weight * Price;
        }
    }
}
