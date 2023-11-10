using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casher
{
    class CSum
    {
        private static double sp, tot;  //分別存放單項收費與累計收費金額
        public CSum(CFruit f)
        {
            sp = f.spend();
            tot += sp;
        }
        public string priceMsg()
        {
            return $"單項收費：{sp} 元";
        }
        public string totMsg()
        {
            return $"累計收費：{tot} 元";
        }
    }
}
