﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the score which you want to applie bonus points: ");
            int score = int.Parse(Console.ReadLine());


            if (score >= 1 && score <= 3)
            { score *= 10; Console.WriteLine(score); }
            else if (score >= 4 && score <= 6)
            { score *= 100; Console.WriteLine(score); }
            else if (score >= 7 && score <= 9)
            { score *= 1000; Console.WriteLine(score); }
            else
                Console.WriteLine("This is an error message");

            

        }
    }
}
