using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override2
{
    class Person : Animal
    {
        public new string Mammal  
        {
            get { return "人"; } 
        }
        public string Special
        {
            get { return "智慧"; } 
        }
        public override string msg()
        {
            base.Mammal = "狗";　
            string st = base.msg();
            st += $"\r\n{Mammal} 是 {kind} \r\n" +
                  $"{Mammal} 是 {Special} 的 {kind}";
            return st;
        }
    }
}
