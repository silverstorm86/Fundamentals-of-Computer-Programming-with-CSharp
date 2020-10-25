using System;


namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 0.1f;
            Console.WriteLine(f); //correct due to rounding
            double d = 0.1f;
            Console.WriteLine(d); //incorrect

            float ff = 1.0f / 3;
            Console.WriteLine(ff); //correct due to rounding
            double dd = ff;
            Console.WriteLine(dd); //incorrect

            decimal decimalPI = 3.14159265358979323846m;
            Console.WriteLine(decimalPI);
        }
    }
}
