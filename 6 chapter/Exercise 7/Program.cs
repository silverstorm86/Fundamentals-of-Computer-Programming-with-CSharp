using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static long Factorial(long num)
        {
            long fac = 1;

            for (int i = 1; i <= num; i++)
            {
                fac *= i;
            }

            return fac;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial operation");
            Console.Write("Give me the first number: ");
            long n = long.Parse(Console.ReadLine());
            while (n < 0)
            {
                Console.Write("Give me number greater than 0: ");
                n = long.Parse(Console.ReadLine());
            }
            Console.Write("Give me the second number: ");
            long k = long.Parse(Console.ReadLine());
            while (k < 1 && k > n)
            {
                Console.Write("Give me number greater than 1 and smaller than the first number: ");
                n = long.Parse(Console.ReadLine());
            }

            long nf = Factorial(n);
            long kf = Factorial(k);
            Console.WriteLine("First factorial: " + nf);
            Console.WriteLine("Second factorial: " + kf);
            Console.WriteLine("The result after n!*k!/(n-k)! operation: " + (decimal)(nf * kf) / (decimal)(Factorial(n-k)));

        }
    }
}
