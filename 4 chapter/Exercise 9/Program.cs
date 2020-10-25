using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num, sum=0;
            for (int i = 1; i < 3; i++)
            {
                string str;
                bool bl;
                do
                {
                    Console.Write("Give me the {0} number: ", i);
                    str = Console.ReadLine();
                    bl = Int32.TryParse(str, out num);
                    if (bl==false)
                        Console.WriteLine("Give me an integer number!");

                } while (bl == false);

                sum += num;

            }

            Console.WriteLine("The sum of the two given number is : "+sum);


        }
    }
}
