using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathRanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = Math.E;
            Console.WriteLine($"Math.E = {d}");

            d = Math.Exp(1.3);
            Console.WriteLine($"Math.Exp(1.3) = {d}");

            d = Math.Log(1.2);
            Console.WriteLine($"Math.Log(1.2) = {d}");

            d = Math.Log10(1000);
            Console.WriteLine($"Math.Log10(1000) = {d}");

            d = Math.Sqrt(100);
            Console.WriteLine($"Math.Sqrt(100) = {d}");

            d = Math.Pow(2, 5);
            Console.WriteLine($"Math.Pow(2, 5) = {d}");

            int n = Math.Sign(5);
            Console.WriteLine($"Math.Sign(5) = {n}");
            n = Math.Sign(0);
            Console.WriteLine($"Math.Sign(0) = {n}");
            n = Math.Sign(-5);
            Console.WriteLine($"Math.Sign(-5) = {n}");

            d = Math.Abs(-125.6);
            Console.WriteLine($"Math.Abs(-125.6) = {d}");

            d = Math.Floor(4.4);
            Console.WriteLine($"Math.Floor(4.4) = {d}");

            d = Math.Ceiling(4.4);
            Console.WriteLine($"Math.Ceiling(4.4) = {d}");

            d = Math.Round(4.5);
            Console.WriteLine($"Math.Round(4.5) = {d}");

            d = Math.Round(5.5);
            Console.WriteLine($"Math.Round(5.5) = {d}");

            d = Math.Max(77.5, 109.8);
            Console.WriteLine($"Math.Max(77.5, 109.8) = {d}");

            n = Math.Min(7, 10);
            Console.WriteLine($"Math.Min(7, 10) = {n}");

            d = Math.PI;
            Console.WriteLine($"Math.PI = {d}");

            double d1 = 30 * (Math.PI / 180);//角度為30°
            double d2 = Math.Sin(d1);
            Console.WriteLine($"Math.Sin(30 * (Math.PI / 180)) = {d2}");

            d1 = 30 * (Math.PI / 180);//角度為30°
            d2 = Math.Cos(d1);
            Console.WriteLine($"Math.Cos(30 * (Math.PI / 180)) = {d2}");

            d1 = 45 * (Math.PI / 180);//角度為45°
            d2 = Math.Tan(d1);
            Console.WriteLine($"Math.Tan(45 * (Math.PI / 180)) = {d2}");

            Random rnd = new Random();
            n = rnd.Next();
            Console.WriteLine($"rnd.Next() = {n}");

            n = rnd.Next(49);
            Console.WriteLine($"rnd.Next(49) = {n}");

            n = rnd.Next(-5, 6);
            Console.WriteLine($"rnd.Next(-5, 6) = {n}");

            byte[] ary = new byte[4];
            rnd.NextBytes(ary);
            foreach (byte a in ary)
                Console.Write($"{a},");
            Console.WriteLine("");

            d = rnd.NextDouble();
            Console.WriteLine($"rnd.NextDouble() = {d}");

            Console.Read();
        }
    }
}
