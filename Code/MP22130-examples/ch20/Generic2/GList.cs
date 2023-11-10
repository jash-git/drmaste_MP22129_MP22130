using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    class GList<T>                    // 宣告泛型類別GList
    {
        private T[] ary = new T[5];   // T 為型別引數，可存放 5 個資料
        private int index;            // 陣列索引值

        public void SaveToAry(T tData)   // 存放資料到陣列
        {
            if (index<ary.Length)
            {
                ary[index] = tData;
                index++;
            }
        }

        public String data()
        {
            string st = "";
            for (int k = 0; k<ary.Length; k++)
                st += $" ary[{k}] = {ary[k]} \r\n";
            return st;
        }
    }
}
