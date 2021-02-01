using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hexadeimal to Decimal
            Console.Write("Give me a hexadeimal number: ");
            string hexa = Console.ReadLine();
            int dec = 0;

            
                for (int i = 0; i != hexa.Length; i++)
                {
                    char c = hexa[i];
                    int tmpDec = Convert.ToInt32(HexToDec(c)) * (int)Math.Pow(16, hexa.Length - 1 - i);
                    dec += tmpDec;
                }
            
            Console.WriteLine("Hexadecimal converted to decimal: "+dec);
        }

        private static int HexToDec(char hexa)
        {
            switch (hexa)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
                default:
                    break;
            }
            return default;
        }

    }
}
