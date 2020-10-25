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
            int a = 7 + 9;
            Console.WriteLine(a);//16

            string firstName = "John";
            string lastName = "Doe";

            // Do not forget the space between them
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName); // Joe Doe

            int x = 50, y = 100, z;

            //Ambiguous
            z = x + y / 100;
            Console.WriteLine(z);

            //Unambiguous, recommended
            z = x + (y / 100);
            Console.WriteLine(z);

        }
    }
}
