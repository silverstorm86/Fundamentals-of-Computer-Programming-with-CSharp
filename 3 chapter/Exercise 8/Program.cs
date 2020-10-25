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
            Console.WriteLine("Give me x and y points");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
             
            Console.WriteLine("The point is {0} the circle", (((x * x) + (y * y) <= 5 * 5)? "in" : "out of"));



        }
    }
}
