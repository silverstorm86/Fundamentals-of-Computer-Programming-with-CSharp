using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3___Standard_Numeric_Formats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Standard Numeric Formats

            Console.WriteLine("{0:C2}", 123.456); //£123.46
            Console.WriteLine("{0:D6}", -1234); //-001234
            Console.WriteLine("{0:E2}", 123); //1.23E+002
            Console.WriteLine("{0:F2}", -123.456); //-123.46
            Console.WriteLine("{0:N2}", 1234567.8); //1,234,567.80
            Console.WriteLine("{0:P}", 0.456); //45.60%
            Console.WriteLine("{0:X}", 254); //FE
        }
    
    }
}
