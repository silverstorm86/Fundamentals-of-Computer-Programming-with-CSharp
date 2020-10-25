using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p=0;
            do
            {
                Console.WriteLine("Give me a number between 1 and 100");
                int.TryParse(Console.ReadLine(), out n);
            }
            while (n < 1 || n > 100);
            for (int i = 1; i < n; i++)
            {
                if (n % i==0)
                {
                    p++;
                }

            }

            Console.WriteLine("This number {0} a Prime number",(p <= 2? "is" : "is not"));


        }
    }
}
