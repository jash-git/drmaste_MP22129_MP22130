using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Visual C# 目前很夯";
            int n = str.Length;
            Console.WriteLine($"{str}.Length = {n}");

            n = 1200;
            string str1 = n.ToString();
            Console.WriteLine($"整數{n}.ToString = {str1}");

            DateTime dT1;
            dT1 = new DateTime(2022, 9, 15, 8, 30, 7);
            str1 = dT1.ToString();
            Console.WriteLine($"日期時間dT1.ToString = {str1}");

            str = "3.14";
            double d;
            d = 10 * double.Parse(str);
            Console.WriteLine($"{d}");

            str = "Visual";
            Boolean yN = str.Equals("Visual");
            Console.WriteLine($"Visual.Equals(Visual) = {yN}");

            str1 = "AAA";
            string str2 = "ABC";
            n = str1.CompareTo(str2);
            Console.WriteLine($"AAA.CompareTo(ABC) = {n}");

            str = "He is John.";
            str1 = str.ToUpper();
            Console.WriteLine($"{str}.ToUpper = {str1}");

            str1 = str.ToLower();
            Console.WriteLine($"{str}.ToLower = {str1}");

            str = "1234567890123456".Substring(8, 4);
            Console.WriteLine($"{str}.Substring(8, 4) = {str}");

            str = "abcdefgh".Remove(3, 4);
            Console.WriteLine($"{str}.Remove(3, 4) = {str}");

            str = "12345678".Insert(5, "abc");
            Console.WriteLine($"{str}.Insert(5, \"abc\") = {str}");

            str = "2468024680".Replace("46", "x");
            Console.WriteLine($"{str}.Replace(\"46\", \"x\") = {str}");

            n = "ABC and ABS ".IndexOf("AB");
            Console.WriteLine($"\"ABC and ABS \".IndexOf(\"AB\") = {n}");

            n = "ABC and ABS ".LastIndexOf("AB");
            Console.WriteLine($"{n}");

            yN = "ABC and ABS ".StartsWith("AB");
            Console.WriteLine($"{yN}");

            yN = "ABC and ABS ".EndsWith("AB");
            Console.WriteLine($"{yN}");

            str = "   Visual C#  ".TrimStart();
            Console.WriteLine($"\"   Visual C#  \".TrimStart = {str}");

            str = "   Visual C#  ".TrimEnd();
            Console.WriteLine($"\"   Visual C#  \".TrimEnd = {str}");

            str = "   Visual C#  ".Trim();
            Console.WriteLine($"\"   Visual C#  \".Trim = {str}");

            str = "123".PadLeft(5, '0');
            Console.WriteLine($"\"123\".PadLeft(5, '0') = {str}");

            str = "ABC".PadRight(5, '*');
            Console.WriteLine($"\"ABC\".PadRight(5, '*') = {str}");

            string[] s = "1,2,3,4".Split(',');
            foreach (string ss in s)
                Console.Write($"{ss},");
            Console.WriteLine("");

            string[] s1 = { "A", "B", "C", "D" };
            str = String.Join(",", s1);
            Console.WriteLine($"{str}");

            char[] c = "12345".ToCharArray(1, 3);
            foreach (char c1 in c)
                Console.Write($"{c1},");
            Console.WriteLine("");

            str = "123456";
            char[] c2 = { 'A', 'B', 'C', 'D' };
            str.CopyTo(3, c2, 1, 2);
            foreach (char c1 in c2)
                Console.Write($"{c1},");

            Console.Read();
        }
    }
}
