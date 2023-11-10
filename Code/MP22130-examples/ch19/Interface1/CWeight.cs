using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    class CWeight : IConvert
    {
        private double mult = 453.59;   // 1 lb = 453.59 g
        public double Mult            // 實作Mult屬性
        {
            get { return mult; }
            set { mult = value; }
        }
        public double Convert(double lb)   // 實作Convert()方法
        {
            return lb * Mult;
        }
    }
}
