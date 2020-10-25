using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the real roots of quadratic equation");
            Console.Write("Give me the first coefficient: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Give me the second coefficient: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Give me the third coefficient: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("The given quadratic equation is y={0}{1}x²{2}{3}x{4}{5}", a > 0 ? "+" : "", a, b > 0 ? "+" : "", b, c > 0 ? "+" : "", c);
            
            double D=(b*b)-(4*a*c);
            double x1, x2;

            if (D ==0)
            {
                x1 = (-b) / (2 * a);

                Console.WriteLine("The quadratic equations has one root {0:0.00}", x1);
            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                x2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                Console.WriteLine("The quadratic equations first root is {0:0.00} and second is {1:0.00}", x1, x2);
            }
            else
                Console.WriteLine("The quadratic equation has no real root");
        }
    }
}
