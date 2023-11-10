using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dT1 = new DateTime();
            dT1 = DateTime.Now;
            Console.WriteLine($"DateTime.Now = {dT1}");

            dT1 = DateTime.Today;
            Console.WriteLine($"DateTime.Today = {dT1}");

            dT1 = new DateTime(2021, 9, 15, 14, 5, 6);
            DateTime dT2 = dT1.Date;
            Console.WriteLine($"dT1 = {dT1}");
            Console.WriteLine($"dT1.Date = {dT2}");

            dT1 = new DateTime(2021, 9, 15, 14, 5, 6);
            int n = dT1.Year;
            Console.WriteLine($"dT1.Year = {n}");

            dT1 = new DateTime(2021, 9, 15, 14, 5, 6);
            string str1 = dT1.ToString();
            string str2 = dT1.ToLongDateString();
            string str3 = dT1.ToShortDateString();
            Console.WriteLine($"dT1.ToString() = {str1}");
            Console.WriteLine($"dT1.ToLongDateString() = {str2}");
            Console.WriteLine($"dT1.ToShortDateString() = {str3}");

            str1 = dT1.ToLongTimeString();
            str2 = dT1.ToShortTimeString();
            Console.WriteLine($"dT1.ToLongTimeString() = {str1}");
            Console.WriteLine($"dT1.ToShortTimeString() = {str2}");

            dT1 = Convert.ToDateTime("2021-9-15");
            dT2 = Convert.ToDateTime("2021-9-15 14:05:06");
            Console.WriteLine($"Convert.ToDateTime(\"2021 - 9 - 15\") = {dT1}");
            Console.WriteLine($"Convert.ToDateTime(\"2021 - 9 - 15 14:05:06\") = {dT2}");

            dT1 = new DateTime(2021, 9, 15, 14, 5, 6);
            dT2 = dT1.AddDays(5);
            DateTime dT3 = dT1.AddYears(1);
            Console.WriteLine($"dT1.AddDays(5) = {dT2}");
            Console.WriteLine($"dT1.AddYears(1) = {dT3}");

            dT1 = new DateTime(2021, 9, 15, 14, 5, 6);
            dT2 = new DateTime(2021, 10, 17, 18, 5, 6);
            Console.WriteLine($"dT1 = {dT1}");
            Console.WriteLine($"dT2 = {dT2}");
            TimeSpan ts = dT2.Subtract(dT1);
            Console.WriteLine($"dT2.Subtract(dT1) = {ts}");
            double d1 = ts.Days;
            double d2 = ts.TotalDays;
            Console.WriteLine($"ts.Days = {d1}");
            Console.WriteLine($"ts.TotalDays = {d2}");

            Console.Read();
        }
    }
}
