using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Give me the first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Give me the second number: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.Write("Give me the third number: ");
                int num3 = int.Parse(Console.ReadLine());

                int biggest = 0;

                if (num1 > num2)
                    biggest = num1;
                else
                    biggest = num2;

                if (biggest < num3)
                    biggest = num3;



                Console.WriteLine("The biggest of the given number is {0}", biggest);
            }
        }
    }
}
