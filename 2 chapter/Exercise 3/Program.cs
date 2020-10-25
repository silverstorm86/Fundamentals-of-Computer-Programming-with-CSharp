using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Write two real numbers :");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a > b) Console.WriteLine("The first number is greater than the second");
            else if ((a - b) < 0.000001) Console.WriteLine("The two numbers are same");
            else Console.WriteLine("The second number is greater than the first");

        }
    }
}
