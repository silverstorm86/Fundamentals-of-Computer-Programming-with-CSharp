using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the first number for the sum : ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Give me the second number for the sum : ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Give me the third number for the sum : ");
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of the writen numbers are :" + (first + second + third));
        }
    }
}
