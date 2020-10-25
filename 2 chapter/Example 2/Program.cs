using System;


namespace Example_2
{
    class Program
    {
        static void Main()
        {
            float floatPI = 3.141592653589793238f;
            Console.WriteLine(floatPI);
            double doublePI = 3.141592653589793238;
            Console.WriteLine(doublePI);
            double nan = Double.NaN;
            Console.WriteLine(nan);
            double infinity = Double.PositiveInfinity;
            Console.WriteLine(infinity);
        }
    }
}
