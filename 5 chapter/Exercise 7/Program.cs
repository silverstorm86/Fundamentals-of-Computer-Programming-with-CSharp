using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Give me the second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Give me the third number: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Give me the fourth number: ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Give me the fifth number: ");
            int e = int.Parse(Console.ReadLine());

            int big = a;

            for (int i = 0; i <= 5; i++)
            {
                if (big < b)
                    big = b;
                else if (big < c)
                    big = c;
                else if (big < d)
                    big = d;
                else if (big < d)
                    big = d;
                else if (big < e)
                    big = e;
                else
                    break;
            }

            Console.WriteLine("The biggest of the given numbers is: "+big);

        }

    }
}
