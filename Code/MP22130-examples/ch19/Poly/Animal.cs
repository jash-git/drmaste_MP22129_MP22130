using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    class Animal      //父類別
    {
        public virtual string msg()       // 允許被子類別覆寫
        {
            return "現在是執行 父類別 Animal";
        }
    }
}
