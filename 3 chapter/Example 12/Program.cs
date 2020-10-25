using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 5.1d;
            Console.WriteLine(myDouble); //5.1

            long myLong = (long)myDouble;
            Console.WriteLine(myLong); //5

            myDouble = 5e9d; //5* 10^9
            Console.WriteLine(myDouble);//5000000000

            int myInt = (int)myDouble;
            Console.WriteLine(myInt);//-2147483648
            Console.WriteLine(int.MinValue);//-2147483648

            myLong = long.MaxValue;
            myInt = (int)myLong;

            Console.WriteLine(myLong); //9223372036854775807
            Console.WriteLine(myInt); //-1

            float heightInMeters = 1.74f; //Explicit conversion
            double maxHeight = heightInMeters; //Implicit
            double minHeight = (double)heightInMeters; //Explicit
            Console.WriteLine(minHeight);
            float actualHeight = (float)maxHeight; //Explicit
            Console.WriteLine(actualHeight);

            /*float maxHeightFloat = maxHeight;*/ //Compilation error!

            double d = 5e9d; //5*10^9
            Console.WriteLine(d); //5000000000
            int i = checked((int)d); //System.OverflowException
            Console.WriteLine(i);
        }
    }
}
