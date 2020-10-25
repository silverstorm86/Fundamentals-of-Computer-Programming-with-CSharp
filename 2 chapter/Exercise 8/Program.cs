using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object obj = a + " " + b;
            Console.WriteLine(obj);
            string str = (string)obj;
            Console.WriteLine(str);

        }
    }
}
