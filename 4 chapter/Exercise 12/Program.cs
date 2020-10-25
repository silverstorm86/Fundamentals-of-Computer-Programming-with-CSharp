using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            float current_sum = 1, old_sum = 0;
            float frac = 2F;

            while (Math.Abs(current_sum-old_sum)>0.001)
            {
                old_sum = current_sum;
                if (frac % 2 ==0)
                {
                    current_sum = old_sum + (1 / frac);
                }
                else
                {
                    current_sum = old_sum - (1 / frac);
                }
                frac++;
            }

            Console.WriteLine("{0:0.000 }",current_sum);
        }
    }
}
