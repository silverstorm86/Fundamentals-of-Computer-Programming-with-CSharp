using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // "decimal" is the biggest C# type that can hold integer values
            decimal factorial = 1;
            // Perform an "infinite loop"
            while (true)
            {
                if (n <= 1)
                    break;
                
                factorial *= n;
                n--;
            }
            Console.WriteLine("n! = " + factorial);
        }
    }
}
