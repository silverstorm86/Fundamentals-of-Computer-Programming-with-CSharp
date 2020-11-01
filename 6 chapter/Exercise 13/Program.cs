using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {

            //From binary to decimal
            Console.WriteLine("Convert from decimal to binary!");
            Console.Write("Give me one positive binary: ");
            string ns = Console.ReadLine();

            while (!Regex.Match(ns, "^[0-1]*$").Success)
            {
                Console.WriteLine("Wrong input!");
                Console.Write("Try again: ");
                ns = Console.ReadLine();
            }

            int num = Convert.ToInt32(ns);
            double decim = 0;

            for (int i = 0; i<= ns.Length; i++)
            {
               double temp = Math.Pow(2, i);
                int temo = num % 10;
                num = num / 10;
                decim += (temo*temp);
            }

            Console.WriteLine(decim);
        }
    }
}
