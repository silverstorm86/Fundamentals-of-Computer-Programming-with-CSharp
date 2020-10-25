using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static long Factorial(long x)
        {
            long fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate catalan numbers by formula");
            Console.Write("Give me one number which is greater or equal to zero: ");
            long n = long.Parse(Console.ReadLine());
            while (n<0)
            {
                Console.Write("The number must be greater or equal to zero: ");
                n = long.Parse(Console.ReadLine());
            }

            Console.WriteLine("The factorial of the given number: "+Factorial(n));

            Console.WriteLine("The Catalan number of the given number is: "+ (Factorial(2*n))/(Factorial(n+1)*Factorial(n)));
            
        }
    }
}
