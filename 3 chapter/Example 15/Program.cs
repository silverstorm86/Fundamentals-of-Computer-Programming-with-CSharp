using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            double denum = 0;// The value is 0.0 (real number)
            int zeroInt = (int)denum;// The value is 0(integer number)
            Console.WriteLine(num/denum); //Infinity
            Console.WriteLine(denum/denum); //NaN
            Console.WriteLine(zeroInt/zeroInt); //DivideByZeroException
        }
    }
}
