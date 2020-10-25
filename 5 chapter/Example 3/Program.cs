using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "beer";
            string anotherStr = str;
            string thirdStr = "bee";
            thirdStr += 'r';
            Console.WriteLine("str = {0}", str);
            Console.WriteLine("anotherStr = {0}", anotherStr);
            Console.WriteLine("thirdStr = {0}", thirdStr);
            Console.WriteLine(str == anotherStr);
            Console.WriteLine(str == thirdStr);
            Console.WriteLine((object)str == (object)anotherStr);
            Console.WriteLine((object)str == (object)thirdStr);
        }
    }
}
