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
            Console.WriteLine("Give me one whole number :");
            int num = int.Parse(Console.ReadLine());
            bool or = false;
            Console.WriteLine("Is this number divisible by 7 and 5?");
            if (num%35==0)
                or = true;
            Console.WriteLine("{0} this number {1} divisible by 7 and 5.", (or ? "Yes" : "No"), (or ? "is" : "isn't"));
               
        }
    }
}
