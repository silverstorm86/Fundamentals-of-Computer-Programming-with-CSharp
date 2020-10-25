using System;


namespace Example_4
{
    class Program
    {
        static void Main()
        {
            //Declare some variables
            int a = 1, b = 2;
            //Which one is greater?
            bool greaterAB = (a > b);
            //is 'a'equal to 1?
            bool equalA1 = (a == 1);
            //Print the result on the console
            if(greaterAB)
            {
                Console.WriteLine("A>B");
            }
            else
            {
                Console.WriteLine("A<=B");
            }

            Console.WriteLine("greaterAB ="+greaterAB);
            Console.WriteLine("equalA1 ="+equalA1);

        }
    }
}
