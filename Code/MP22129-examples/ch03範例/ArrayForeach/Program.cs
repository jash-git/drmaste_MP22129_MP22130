using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] msg = new string[4] { "Time", "is", "money", "." };
            foreach (string word in msg)
                Console.Write($"{word} ");  //每輸出一個word後空一格游標不下移
            Console.Read();
        }
    }
}
