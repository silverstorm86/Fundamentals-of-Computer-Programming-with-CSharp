using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = 700;
            Console.WriteLine(weight >= 500); //True

            char gender = 'm';
            Console.WriteLine(gender <= 'f'); //False

            double colorWaveLenght = 1630;
            Console.WriteLine(colorWaveLenght > 1621); //True

            int a = 5;
            int b = 7;
            bool condition = (b > a) && (a + b < a * b);
            Console.WriteLine(condition); // True

            Console.WriteLine('B' == 'A' +1); // True

        }
    }
}
