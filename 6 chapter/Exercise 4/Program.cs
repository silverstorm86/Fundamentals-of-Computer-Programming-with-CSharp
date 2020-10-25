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
            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.Write("club: ");
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.Write("diamond: ");
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("heart: ");
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.Write("spades: ");
                        break;
                }
                for (int j = 2; j <= 14; j++)
                {
                    if (j<=10)
                    {
                        Console.Write(i+", ");
                    }
                    switch (j)
                    {
                        case 11:
                            Console.Write("J, ");
                            break;
                        case 12:
                            Console.Write("Q, ");
                            break;
                        case 13:
                            Console.Write("K, ");
                            break;
                        case 14:
                            Console.Write("A");
                            break;
                    }
                    
                }
            }
            Console.WriteLine();

        }
    }
}
