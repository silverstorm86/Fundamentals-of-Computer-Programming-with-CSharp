using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me the position of the bit: ");
            int p = int.Parse(Console.ReadLine());

            int i = 1, mask;

            mask = i << p; // move the number 1 left to position in mask
            int bit = (mask & n) == 0 ? 0 : 1;
            Console.WriteLine("The bit on the given position in the number is : " + bit);

            Console.WriteLine("The bit on the give {0} position is 1 : {1}", p , bit == 1 ? true : false);
        }
    }
}
