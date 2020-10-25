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
            int num = 2, i, x = -1;
            for (i = 1; i < 100; i++)
            {
                Console.WriteLine(num);
                if(num % 2 == 0)
                {
                    num++;
                    num *= x;
                }
                else
                {
                    num *= x;
                    num++;
                }

                
            }


        }
    }
}
