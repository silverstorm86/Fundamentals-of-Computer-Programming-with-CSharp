using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Program
    {
       
        static void Main()
        {

            //Conert deimal to hexadeimal

            Console.WriteLine("Convert decimal to hexadecimal.");
            Console.Write("Give me one whole decimal number: ");
            int dec = Convert.ToInt32(Console.ReadLine());

            if (dec < 16)
            {
                Console.WriteLine("The numbers hexadecimal notation is: "+DecToHex(dec));
                
            }
            else
            {
                string result = "";

                for (int i = 0; i < dec;)
                {
                    decimal remaind = dec % 16;
                    result += DecToHex(Convert.ToInt32(remaind));
                    dec /= 16;
                }

                result = new string(result.Reverse().ToArray());

                Console.WriteLine("The numbers hexadecimal notation is: " + result);

            }

            
            
        }
        private static string DecToHex(int dec)
        {
            switch (dec)
            {
                case 0:
                    return "0";
                case 1:
                    return "1";
                case 2:
                    return "2";
                case 3:
                    return "3";
                case 4:
                    return "4";
                case 5:
                    return "5";
                case 6:
                    return "6";
                case 7:
                    return "7";
                case 8:
                    return "8";
                case 9:
                    return "9";
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    break;
            }
            return "";
        }

    }
}
