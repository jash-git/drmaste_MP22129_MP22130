using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    class Person : Animal               // 子類別Person繼承父類別Animal
    {
        public override string msg()    // 覆寫父類別的msg()方法
        {
            return "現在是執行 子類別 Person";
        }
    }
}
