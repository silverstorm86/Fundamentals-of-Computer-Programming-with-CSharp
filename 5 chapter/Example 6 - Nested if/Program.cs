using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_6___Nested_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 5;
            int second = 3;

            if (first == second)
            {
                Console.WriteLine("These two numbers are equal.");
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine("The first number is greater. ");
                }
                else
                {
                    Console.WriteLine("The second number is greater. ");
                }
            }
        }
    }
}
