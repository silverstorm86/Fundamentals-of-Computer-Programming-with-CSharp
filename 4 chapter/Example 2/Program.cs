﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,6}",123);
            Console.WriteLine("{0,6}", 1234);
            Console.WriteLine("{0,6}",12);
            Console.Write("{0,-6}", 123);
            Console.WriteLine("--end");
        }
    }
}
