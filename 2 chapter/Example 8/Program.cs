using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int? ni = i;
            Console.WriteLine(ni);

            // i = ni; //this will fail to compile
            Console.WriteLine(ni.HasValue);
            i = ni.Value;
            Console.WriteLine(i);

            ni = null;
            Console.WriteLine(ni.HasValue);
            //i = ni.Value; // System.InvalidOperationException
            i = ni.GetValueOrDefault();
            Console.WriteLine(i);
        }
    }
}
