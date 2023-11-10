using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override2
{
    class Animal
    {
        protected string kind = "動物";        
        public string Mammal { set; get; }
        public virtual string msg()
        {
            return $"{Mammal} 是 {kind}";
        }
    }
}
