﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b); //False
            Console.WriteLine(a || b); //True
            Console.WriteLine(!b); //True1
            Console.WriteLine(b || true); //True
            Console.WriteLine((5 > 7) ^ (a == b)); //False
        }
    }
}
