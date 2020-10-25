using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4___Custom_Numeric_Formats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:0.00}", 1); //1.00
            Console.WriteLine("{0:#.##}", 0.234); //.23
            Console.WriteLine("{0:#####}", 12345.67); //12346
            Console.WriteLine("{0:(0#) ### ## ##}", 29342525); //(02) 934 25 25
            Console.WriteLine("{0:%##}", 0.234); //%23

        }
    }
}
