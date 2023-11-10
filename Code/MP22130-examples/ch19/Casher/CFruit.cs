using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casher
{
    class CFruit
    {
        public double Price { get; set; }   // Price為價格屬性
        public virtual double spend()   // 空殼的spend()方法，允許被覆蓋
        {
            return 0;
        }
    }
}
