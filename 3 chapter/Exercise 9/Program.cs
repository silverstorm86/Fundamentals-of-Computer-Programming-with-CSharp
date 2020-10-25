using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me x and y points");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            const byte radius= 5;
            const sbyte leftXrec = -1;
            const sbyte upXrec = 5;
            const sbyte rightYrec = 5;
            const sbyte downYrec = 1;
            bool inCircle = ((x * x) + (y * y) <= radius * radius);
            bool inRectangle = y >= downYrec && y <= rightYrec && x >= leftXrec && x <= upXrec;

            Console.Write("The given point is "+(inCircle ? "inside" : "outside")+" the circle, ");
            Console.WriteLine("and "+(inRectangle ? "inside" : "outside")+" the rectangle" );


        }
    }
}
