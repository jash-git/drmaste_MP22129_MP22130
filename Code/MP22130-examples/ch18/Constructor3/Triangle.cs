using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor3
{
    class Triangle
    {
        private int _Base = 15;        // Base屬性預設值
        public int Base
        {
            get { return _Base; }
            set { _Base = value; }
        }

        private int _High = 15;       // High屬性預設值
        public int High
        {
            get { return _High; }
            set { _High = value; }
        }
              
        public double GetArea()       // 方法成員
        {
            return (double) Base * High / 2;
        }
    }
}
