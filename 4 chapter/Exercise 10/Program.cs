using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool bl;
            do
            {
                string str;
                Console.Write("Give me the number: ");
                str = Console.ReadLine();
                bl = Int32.TryParse(str, out num);
                if (bl==false)
                    Console.WriteLine("Give me one integer number");
                
            } while (bl==false);

            for (int i = 1; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
