using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //From decinal to binary
            Console.WriteLine("Convert to binary from decimal!");
            Console.Write("Give me one positive integer: ");
            string ns = Console.ReadLine();
            
            while (!Regex.Match(ns, "^[0-9]*$").Success || !(int.Parse(ns)>=0))
            {
                Console.WriteLine("Wrong input!");
                Console.Write("Try again: ");
                ns = Console.ReadLine();
            }

            int n = Convert.ToInt32(ns);

            int bin;
            string binary="";
            do
            {
                bin = n % 2;
                if (bin == 0)
                    binary += "0";
                else
                    binary += "1";
                n = n / 2;
            } while (n != 1);

            binary += "1";

            string binaryrev = "";
            for (int i = binary.Length-1; i >= 0 ; i--)
            {
                binaryrev += binary[i];
            }

            Console.WriteLine(binaryrev);
        }
    }
}
