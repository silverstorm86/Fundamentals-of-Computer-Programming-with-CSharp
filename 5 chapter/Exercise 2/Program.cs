using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Give me the first number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Give me the second number: ");
                double num2 = double.Parse(Console.ReadLine());
                Console.Write("Give me the third number: ");
                double num3 = double.Parse(Console.ReadLine());
                int negativeNumberCount =0 ;

                if (num1 < 0 )
                    negativeNumberCount++;
                if (num2 < 0)
                    negativeNumberCount++;
                if (num3 < 0)
                    negativeNumberCount++;

                if (num1 == 0 || num2 == 0 || num3 == 0)
                    Console.WriteLine("0");
                else if (negativeNumberCount == 0 || negativeNumberCount==2)
                    Console.WriteLine("+");
                else
                    Console.WriteLine("-");
                
                Console.WriteLine("The first number {0} the second number {1} the third number {2}", num1, num2, num3);
            }
        }
    }
}
