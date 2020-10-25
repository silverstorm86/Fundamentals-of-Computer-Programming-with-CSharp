using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num, bigger=0;
            string str;
            bool bl;

            for (int i = 1; i <= 5; i++)
            {
                do
                {
                    Console.Write("Give me the {0} number : ", i);
                    str = Console.ReadLine();
                    bl = Int32.TryParse(str, out num);
                    if (bl == false)
                        Console.Write("This is not an integer give me a number\n");
                }
                while (bl == false);

                if (bigger<num)
                    bigger = num;
            }
            Console.WriteLine("The greatest number of the given numbers is : "+bigger);

        }
    }
}
