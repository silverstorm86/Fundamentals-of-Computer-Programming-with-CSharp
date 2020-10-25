using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 100 Fibonacci numbers are :");

            decimal num = 0, numtmp = 1, tmp;

            for (int i = 0; i < 100; i++)
            {
                
                Console.Write(num+", ");
                tmp = num;
                num = num + numtmp;
                numtmp = tmp;

            }
        }
    }
}
