using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
            Console.WriteLine("{0:d.MM.yy}", d);

            Console.WriteLine("{0:G}", DayOfWeek.Saturday);
            Console.WriteLine("{0:D}", DayOfWeek.Saturday);
            Console.WriteLine("{0:X}", DayOfWeek.Saturday);
        }
    }
}
