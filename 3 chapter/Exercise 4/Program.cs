using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me one integer number :");
            int num = int.Parse(Console.ReadLine());
            bool bit3 = (num & 4) != 0;

            Console.WriteLine("The third bit is "+(bit3 ? 1 : 0));
                       
        }
    }
}