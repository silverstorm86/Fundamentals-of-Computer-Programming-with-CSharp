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
            Console.Write("Give me the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give me the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1>num2)
            {
                int tmp = num1;
                num1 = num2;
                num2 = tmp;
            }

            Console.WriteLine("The first number {0} the second number {1}", num1, num2);
        }
    }
}
