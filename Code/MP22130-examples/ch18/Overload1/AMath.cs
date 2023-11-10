using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload1
{
    class AMath
    {
        public int Add(int num1, int num2)
        {
             return num1 + num2;
        }

        public int Add(int[] num)
        {
            int tot = 0;
            for (int i = 0; i<num.Length; i++)
            {
                tot += num[i];
            }
            return tot;
        }
    }
}
