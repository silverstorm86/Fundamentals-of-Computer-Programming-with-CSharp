using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the first number : ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Give me the second number : ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("The greater number is : {0}", Math.Max(first, second));
            Console.WriteLine("The smaller number is : {0}", Math.Min(first, second));
        }
    }
}
