using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myAry = new int[] { 5, 11, 2, 34, 51, 28, 96 };
            foreach (int getData in myAry)
                Console.Write($" {getData}");
            Console.Read();
        }
    }
}
