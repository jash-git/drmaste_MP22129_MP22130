using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    class UStoNT : IExchange   // 宣告UStoNT類別來實作IExchange介面
    {
        public double Rate       // 實作IExchange介面屬性
        {
            get { return 28.35; }
        }
        public double Convert(double USd)     // 實作IExchange介面方法
        {
            return USd * Rate;
        }
    }
}