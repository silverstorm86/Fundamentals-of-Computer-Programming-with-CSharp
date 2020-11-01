using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise_9
{
       
    class Program
    {
        static int Factorial(int num)
        {
            int fac = 1;
            for (int i = 1; i <= num ; i++)
            {
                fac *= i;
            }
            return fac;
        }
        static void Main(string[] args)
        {
            Console.Write("Give me the first integer number: ");
            string ns = Console.ReadLine();
            while (!Regex.Match(ns,"^[0-9]*$").Success)
            {
                Console.WriteLine("This is not a number!");
                Console.Write("Number please: ");
                ns = Console.ReadLine();
            }

            int n = int.Parse(ns);

            Console.Write("Give me the second integer number: ");
            string xs = Console.ReadLine();
            while (!Regex.Match(xs, "^[0-9]*$").Success)
            {
                Console.WriteLine("This is not a number!");
                Console.Write("Number please: ");
                xs = Console.ReadLine();
            }

            int x = int.Parse(xs);

            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += (Factorial(i)/Math.Pow((double)x,(double)i));
            }

            Console.WriteLine("The sum by the given formula is "+sum);



        }
    }
}
