using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me one number: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("These numbers are not divisable by 3 : ");
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 != 0)
                    Console.Write(i+" ");
            }
            Console.WriteLine();

            Console.Write("These numbers are not divisable by 7 : ");
            for (int i = 1; i <= num; i++)
            {
                if (i % 7 != 0)
                    Console.Write(i+" ");
            }
        }
    }
}
