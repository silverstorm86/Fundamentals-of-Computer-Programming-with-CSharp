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
            Console.Write("Give me the radius of the circle : ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter of the circle is : {0:0.00}", 2*Math.PI*radius);
            Console.WriteLine("The area of the circle is : {0:0.00}", Math.PI*radius*radius);
        }
    }
}
