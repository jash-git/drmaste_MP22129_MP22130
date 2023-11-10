using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex = "Male";
            string title = "";
            if (sex == "Male")
            {
                title = "Sir";
            }
            else
            {
                title = "Miss";
            }
            Console.WriteLine($"sex = {sex}, title = {title} ");

            sex = "Female";
            title = "";
            if (sex == "Male")      //省略{}
                title = "Sir";
            else
                title = "Miss";
            Console.WriteLine($"sex = {sex}, title = {title} ");
            Console.Read();
        }
    }
}
