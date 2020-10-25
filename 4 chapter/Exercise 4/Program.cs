using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hex = 2013;
            Console.WriteLine("|{0,-10:X}|",hex);
            double fracPos = 1.856;
            Console.WriteLine("|{0,-10:F2}|",fracPos);
            double fracNeg = -1.856;
            Console.WriteLine("|{0,-10:F2}|",fracNeg);

        }
    }
}
