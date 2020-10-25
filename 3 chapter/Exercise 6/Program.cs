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
            Console.Write("Give me the length of the rectangle : ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Give me the height of the rectangle : ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of the rectangle is : {0:0.00}", ((2*lenght)+(2*width)));
            Console.WriteLine("The area of the rectangle is : {0:0.00}", (lenght*width));
        }
    }
}
