using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int v;

            Console.WriteLine("Give me the number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me the position of the bit: ");
            int p = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Give me the bit you want to add to number on that position: ");
                int.TryParse(Console.ReadLine(), out v);
            }
            while (v != 0 && v != 1);


            n &= ~(1 << p); //reset the bit
                        
            n |= (v << p);  //change the bit

            Console.WriteLine("The given number is changed to : "+n);


        }
    }
}
