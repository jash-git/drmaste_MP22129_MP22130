using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    class GType<T>
    {
        public String checkType(T testValue)
        {
            string st = $" Type of {testValue} is {testValue.GetType()}. ";
            return st;
        }
    }
}
