using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Give me the second number: ");
            double b = double.Parse(Console.ReadLine()); 
            Console.Write("Give me the third number: ");
            double c = double.Parse(Console.ReadLine());

            double tmp;

            if (a < b && a < c)
            {
                tmp = a;
                a = c;
                c = tmp;
                if (a<b)
                {
                    tmp = a;
                    a = b;
                    b = tmp;
                }
            }
            else if(b < a && b<c)
            {
                tmp = b;
                b = c;
                c = tmp;
                
                if (a < b)
                {
                    tmp = a;
                    a = b;
                    b = tmp;
                }
            }
            else
            {
                if (a < b)
                {
                    tmp = a;
                    a = b;
                    b = tmp;
                }

            }

            Console.WriteLine("The biggest number is {0} than {1} and the smallest is {2}", a, b,c);

        }
    }
}
