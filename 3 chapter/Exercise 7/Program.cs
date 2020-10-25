using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your weight : ");
            double eweight = double.Parse(Console.ReadLine());

            double mweight = eweight * 0.17;

            Console.WriteLine("Your weight on Moon is : {0:0.00}",mweight);
        }
    }
}
