using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int codeRead = 0;
            do
            {
                codeRead = Console.Read();
                if (codeRead != 0)
                {
                    Console.Write((char)codeRead);
                }
            }
            while (codeRead != 10);

    {

            }
        }
    }
}
