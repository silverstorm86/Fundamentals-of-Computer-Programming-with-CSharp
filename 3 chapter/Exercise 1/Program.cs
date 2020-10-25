using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me one hole number :");
            int orOddEven = int.Parse(Console.ReadLine());
            
            Console.WriteLine("This number is {0}", (orOddEven % 2 == 0 ? "even" : "odd")) ;
            
        }
    }
}
