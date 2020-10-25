using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            Console.WriteLine(myInt);

            long myLong = myInt;
            Console.WriteLine(myLong);

            Console.WriteLine(myLong + myInt);
        }
    }
}
