using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {

        static long Factorial(long n)
        {
            long facto = 1;
            for (int i = 1; i <= n; i++)
            {
                facto *= i;
            }
            return facto;
        }
        static void Main(string[] args)
        {
            Console.Write("Give me one positive integer number: ");
            string ns = Console.ReadLine();
            while (!Regex.Match(ns, "^[0-9]*$").Success || !(int.Parse(ns)>0))
            {
                Console.WriteLine("Not a valid input!");
                Console.Write("Try again: ");
                ns = Console.ReadLine();
            }

            long n = Convert.ToInt64(ns);

            n = Factorial(n);

            Console.WriteLine(n);

            int zeros = 0;
            long d = 0;
            do
            {
                d = n % 10;
                n = n / 10;
                if (d == 0)
                {
                    zeros++;
                }
            } while (d == 0);

            Console.WriteLine("The number of zeros in the end of the number: "+ zeros);
        }
    }
}
