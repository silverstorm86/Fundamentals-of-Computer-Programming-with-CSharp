using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third, fourth, fifth;
            
            string a;
            bool aP;
            do
            {
                Console.Write("First number : ");
                a = Console.ReadLine();
                aP = Int32.TryParse(a, out first);
                if(aP == false) 
                    Console.Write("This is not an integer give me a number\n");
            }
            while (aP == false);

            string b;
            bool bP;
            do
            {
                Console.Write("Second number : ");
                b = Console.ReadLine();
                bP = Int32.TryParse(b, out second);
                if (bP == false)
                    Console.Write("This is not an integer give me a number\n");
            }
            while (bP == false);

            string c;
            bool cP;
            do
            {
                Console.Write("Third number : ");
                c = Console.ReadLine();
                cP = Int32.TryParse(c, out third);
                if (cP == false)
                    Console.Write("This is not an integer give me a number\n");
            }
            while (cP == false);

            string d;
            bool dP;
            do
            {
                Console.Write("Fourth number : ");
                d = Console.ReadLine();
                dP = Int32.TryParse(d, out fourth);
                if (dP == false)
                    Console.Write("This is not an integer give me a number\n");
            }
            while (dP == false);

            string e;
            bool eP;
            do
            {
                Console.Write("Fifth number : ");
                e = Console.ReadLine();
                eP = Int32.TryParse(e, out fifth);
                if (eP == false)
                    Console.Write("This is not an integer give me a number\n");
            }
            while (eP == false);

            Console.WriteLine("The sum of the five number is : "+(first+second+third+fourth+fifth));




        }
    }
}
