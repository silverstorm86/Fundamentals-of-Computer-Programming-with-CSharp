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
            string inner = "\"use\"";
            string outer = "\"The "+inner+" of quotations causes difficulties\"";

            Console.WriteLine(outer);
        }
    }
}
