﻿using System;
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
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i+=2)
            {
                if (i % 7 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("sum = " + sum);

        }
    }
}
