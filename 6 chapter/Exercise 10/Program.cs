using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a positive integer number (n<20): ");
            string ns = Console.ReadLine();
            while(!Regex.Match(ns, "^[0-9]*$").Success || !(int.Parse(ns)>0) || !(int.Parse(ns) < 20))
            {
                Console.Write("Not valid input. Try again: ");
                ns = Console.ReadLine();
            }

            int n = int.Parse(ns);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                for (int j = i+1; j <= i+n-1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
