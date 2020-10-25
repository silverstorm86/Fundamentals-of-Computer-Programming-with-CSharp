using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Example_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", d);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("hu-HU");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", d);

        }
    }
}
