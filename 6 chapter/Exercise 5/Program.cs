using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me one number: ");
            int n = int.Parse(Console.ReadLine());
            int num1 = 0, num2= 1;
            int sum = 0;
            Console.WriteLine("The Fibonacci sequence by the given number: ");

            for (int i = 0; i <= n; i++)
            {
                Console.Write(num1+" ");
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                 
            }

        }
    }
}
