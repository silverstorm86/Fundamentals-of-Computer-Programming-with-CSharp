using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_9
{
    class Program
    {
        static void Main()
        {
            int a = 6;
            int b = 4;
            Console.WriteLine(a > b ? "a>b" : "b<=a"); //a>b

            int num = a == b ? 1 : -1; //num will have value -1
            Console.WriteLine(num);
            Console.WriteLine(DateTime.Now); //Prints the date + time

            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[0]); //1
            string str = "Hello";
            Console.WriteLine(str[1]); //e

            int? c = 5;
            Console.WriteLine(c ?? -1); //5
            string name = null;
            Console.WriteLine(name ?? "(no name)"); // (no name)



        }
    }
}
