using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Give me the second number: ");
            int second = int.Parse(Console.ReadLine());
            for (int i=first; i <= second; i++)
            {
                if (i % 5 == 0)
                     Console.WriteLine("The number {2} in a range ({0},{1}) can be divided by 5",first ,second, i);
                
            }

        }
    }
}
