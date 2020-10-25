using System;


namespace Example_5
{
    class Program
    {
        static void Main()
        {
            //Declare a variable
            char ch = 'a';
            //Prinnt the results on the console
            Console.WriteLine(
                "The code of '"+ch+"' is: " +(int)ch);
            ch = 'b';
            Console.WriteLine(
                "The code of '" + ch + "' is: " + (int)ch);
            ch = 'A';
            Console.WriteLine(
                "The code of '" + ch + "' is: " + (int)ch);
        }
    }
}
