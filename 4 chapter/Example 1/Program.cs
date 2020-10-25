using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int age = 26;
            string text = "He is " + age + " years old.";
            Console.WriteLine(text);
            
            //2
            string s = "Four: " + 2 + 2;
            Console.WriteLine(s);

            string s1 = "Four: " + (2 + 2);
            Console.WriteLine(s1);
            
            //3
            string str = "Hello world!";

            Console.WriteLine(str);
            Console.WriteLine("{0}", str);

            //4
            string name = "John";
            int age2 = 18;
            string town = "Seattle";
            Console.Write("{0} is {1} years old from {2}!\n", name, age2, town );

            

        }
    }
}
