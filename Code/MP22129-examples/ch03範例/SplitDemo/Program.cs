using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //例1
            string[] word = "This is a book".Split();  //預設用空白字元分隔
            foreach(string w in word)
            {
                Console.Write($"{w}\t");
            }
            Console.WriteLine("\n");
            string score = "91,92,93,94";   //用 , 逗號字元分隔成績
            string[] sAry = score.Split(',');
            foreach (string s in sAry)
            {
                Console.Write($"{s}\t");
            }
            Console.Read();
        }
    }
}
