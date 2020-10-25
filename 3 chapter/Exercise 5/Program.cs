using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the a side of trapezoid");
            double a = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me the b side of trapezoid");
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me the height of trapezoid");
            double h = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of trapezoid is :");
            Console.WriteLine("{0:0.00}",((a+b)/2)*h);


        }
    }
}
