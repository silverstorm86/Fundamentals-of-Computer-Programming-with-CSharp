using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me one whole number :");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the third digit from right to left of this number 7?");
            int remainder = num / 100;
            remainder = remainder % 10;
            Console.WriteLine("The third digit {0} 7", (remainder == 7? "is":"is not"));
        }
    }
}
