﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Give me the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Give me the thirt number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Give me the fourth number: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Give me the fifth number: ");
            int e = int.Parse(Console.ReadLine());

            if (a == 0)
                Console.WriteLine("{0} is 0", a);
            if (b == 0)
                Console.WriteLine("{0} is 0", b);
            if (c == 0)
                Console.WriteLine("{0} is 0", c);
            if (d == 0)
                Console.WriteLine("{0} is 0", d);
            if (e == 0)
                Console.WriteLine("{0} is 0", e);


            if (a + b == 0)
                Console.WriteLine("The sum of {0} and {1} is 0", a, b);
            if (a + c == 0)
                Console.WriteLine("The sum of {0} and {1} is 0", a, c);
            if (a + d == 0)
                Console.WriteLine("The sum of {0} and {1} is 0", a, d);
            if (a + e == 0)
                Console.WriteLine("The sum of {0} and {1} is 0", a, e);
            if (b + c == 0)
                Console.WriteLine("The sum of {0} and {1} is 0", b, c);
            if (b + d == 0)
                Console.WriteLine("The sum of {0} and {1} is 0", b, d);
            if (b + e == 0)
                Console.WriteLine("The sum of {0} and {1} is 0", b, e);
            if (c + d == 0)
                Console.WriteLine("The sum of {0} and {1} is 0", c, d);
            if (c + e == 0)
                Console.WriteLine("The sum of {0} and {1} is 0", c, e);
            if (d + e == 0)
                Console.WriteLine("The sum of {0} and {1} is 0", d, e);

            if (a + b + c == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} is 0", a, b, c);
            if (a + b + d == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} is 0", a, b, d);
            if (a + b + e == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} is 0", a, b, e);
            if (a + c + d == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} is 0", a, c, d);
            if (a + c + e == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} is 0", a, c, e);
            if (a + d + e == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} is 0", a, d, e);
            if (b + c + d == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} is 0", b, c, d);
            if (b + c + e == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} is 0", b, c, e);
            if (b + d + e == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} is 0", b, d, e);
            if (c + d + e == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} is 0", c, d, e);

            if (a + b + c + d == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} and {3} is 0", a, b, c, d);
            if (b + c + d + e == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} and {3} is 0", b, c, d, e);
            if (a + c + d + e== 0)
                Console.WriteLine("The sum of {0} and {1} and {2} and {3} is 0", a, c, d, e);
            if (a + b + d + e == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} and {3} is 0", a, b, d, e);
            if (a + b + c + e == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} and {3} is 0", a, b, c, e);

            if (a + b + c + d + e == 0)
                Console.WriteLine("The sum of {0} and {1} and {2} and {3} and {4} is 0", a, b, c, d, e);












        }
    }
}
