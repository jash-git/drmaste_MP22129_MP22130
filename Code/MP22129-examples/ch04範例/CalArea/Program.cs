using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalArea
{
    class Rectangle
    {
        public static int Area(int x)
        {
            return x * x;
        }
        // --------------------------------------------------------------------------------------------
        public static int Area(int x, int y)
        {
            return x * y;
        }
        // --------------------------------------------------------------------------------------------
        public static int Area(int x, int y, int z)
        {
            return 2 * (x * y + y * z + z * x);
        }
    }
    // --------------------------------------------------------------------------------------------
    class Triangle
    {
        public double Area(int a, int b)
        {
            return (double)(a * b)/2;
        }
        // --------------------------------------------------------------------------------------------
        public double Area(int a, int b, int c)
        {   //利用海龍公式
            double s=(double)(a + b + c) / 2;
            return Math.Sqrt(s*(s - a)*(s - b)*(s - c));
        }
        // --------------------------------------------------------------------------------------------
        public double Area(int a, int b, byte c)
        {   //利用兩邊長的積乘以正弦值除以2
            return (a*b*Math.Sin(c*(Math.PI/180)))/2;
        }
    }
    // --------------------------------------------------------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            int l = 3;
            int w = 4;
            int h = 5;
            Console.WriteLine($" 1. 正方形的邊長為 {l}，面積為：{Rectangle.Area(l)}");
            Console.WriteLine($" 2. 矩形的長和寬為 {l}、{w}，面積為：{Rectangle.Area(l,w)}");
            Console.WriteLine($" 3. 立方體的長寬高為 {l}、{w}、{h}，表面積為：{Rectangle.Area(l, w, h)}");
            Triangle t = new Triangle();	//建立Triangle類別物件t
            byte r = 90;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($" 1. 三角形的底和高為 {l}、{h}，面積為：{t.Area(l,h):F2}");
            Console.WriteLine($" 2. 三角形的三邊長為 {l}、{w}、{h}，面積為：{t.Area(l, w, h):F2}");
            Console.WriteLine($" 3. 三角形的兩邊長為 {l}、{w}，夾角 {r} 度，面積為：{t.Area(l, w, r):F2}");
            Console.Read();
        }
    }
}
