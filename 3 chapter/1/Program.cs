using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main()
        {
            int a,b;
            Console.WriteLine("Give two number");
            Console.WriteLine("First");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second");
            b = int.Parse(Console.ReadLine());
            while (a!=5 || a!=10)
            {
                Console.WriteLine("Give two number");
                Console.WriteLine("First");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Second");
                b = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(a);
        }
    }
}
