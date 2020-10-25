using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 3;
            Console.WriteLine(a + b / 2);
            Console.WriteLine((a + b) / 2);

            string s = "Beer";
            Console.WriteLine(s is string);

            string notNullString = s;
            string nullString = null;
            Console.WriteLine(nullString ?? "Unspcified");
            Console.WriteLine(notNullString ?? "Specified");
        }
    }
}
