using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num, a, b, c, d;

            do
            {
                Console.WriteLine("Give me one number that contains four digits!");
                str = (Console.ReadLine());
                num = int.Parse(str);
            }
            while (str.Length != 4);

            
            //Get the digits individualy
            a = num % 10;
            b = (num / 10) % 10;
            c = (num / 100) % 10;
            d = (num / 1000) % 10;

            // Calculate the sum of the given number digits
            Console.WriteLine("The sum of the digit is {0}",(a+b+c+d));

            //Prints on the console the number in reversed order
            Console.WriteLine("The reversed order of the digits are: {0}{1}{2}{3}", a, b, c, d);

            //Put the last number in the first position
            Console.WriteLine("The last digit in front of the number: {3}{0}{1}{2}", d, c, b, a);

            //Exchange the second and the third digit
            Console.WriteLine("Exchange the second and the third digit in the number: {0}{2}{1}{3}", d, c, b, a);
        }
    }
}
