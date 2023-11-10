using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override1
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
            return $"{Mammal} 是 {kind} \r\n" +
                   $"{Mammal} 是 {Special} 的 {kind}";
        }
    }
}
