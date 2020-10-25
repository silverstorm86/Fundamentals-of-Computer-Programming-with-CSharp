using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Give me the number you want to convert to words in the range [0...999]: ");
            int num = int.Parse(Console.ReadLine());
            int hund, ten;

            // 100...900
            hund = num / 100;
            if (hund !=0)
            {
                switch (hund)
                {
                    case 1:
                        Console.Write("One Hundred ");
                        break;
                    case 2:
                        Console.Write("Two Hundred ");
                        break;
                    case 3:
                        Console.Write("Three Hundred ");
                        break;
                    case 4:
                        Console.Write("Four Hundred ");
                        break;
                    case 5:
                        Console.Write("Five Hundred ");
                        break;
                    case 6:
                        Console.Write("Six Hundred ");
                        break;
                    case 7:
                        Console.Write("Seven Hundred ");
                        break;
                    case 8:
                        Console.Write("Eight Hundred ");
                        break;
                    case 9:
                        Console.Write("Nine Hundred ");
                        break;
                }
                num %= 100;
            }

            //20....90
            ten = num / 10;

            if (ten >= 2)
            {
                switch (ten)
                {
                    case 2:
                        Console.Write("Twenty ");
                        break;
                    case 3:
                        Console.Write("Thirty ");
                        break;
                    case 4:
                        Console.Write("Fourty ");
                        break;
                    case 5:
                        Console.Write("Fifty ");
                        break;
                    case 6:
                        Console.Write("Sixty ");
                        break;
                    case 7:
                        Console.Write("Seventy ");
                        break;
                    case 8:
                        Console.Write("Eighty ");
                        break;
                    case 9:
                        Console.Write("Ninety ");
                        break;
                }
                num %= 10;
            }

            // 0...19
            if (num > 0 && num <= 19)
            {
                switch (num)
                {
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;
                    case 10:
                        Console.Write("Ten");
                        break;
                    case 11:
                        Console.Write("Eleven");
                        break;
                    case 12:
                        Console.Write("Twelve");
                        break;
                    case 13:
                        Console.Write("Thirteen");
                        break;
                    case 14:
                        Console.Write("Fourteen");
                        break;
                    case 15:
                        Console.Write("Fifthteen");
                        break;
                    case 16:
                        Console.Write("Sixteen");
                        break;
                    case 17:
                        Console.Write("Seventeen");
                        break;
                    case 18:
                        Console.Write("Eightteen");
                        break;
                    case 19:
                        Console.Write("Nineteen");
                        break;
                    default:
                        break;
                }
                
            }
            if (num == 0 && hund == 0 && ten == 0)
                Console.Write("Zero");

            Console.WriteLine();

        }
    }
}
