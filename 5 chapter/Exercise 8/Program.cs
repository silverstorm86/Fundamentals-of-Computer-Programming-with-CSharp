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
            Console.WriteLine("Give me a variable that indicates which type will be the input: ");
            Console.Write("0 = int, 1 = double, 2 = string: ");
            int type = int.Parse(Console.ReadLine());
            
                
            switch (type)
            {
                case 0:
                    {
                        Console.WriteLine("You choose int type");
                        Console.Write("Give me the variable in that type: ");
                        int variable = int.Parse(Console.ReadLine());
                        Console.WriteLine("The variable is increased by 1 = {0}", variable+1);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("You choose doubble type");
                        Console.Write("Give me the variable in that type: ");
                        double variable = double.Parse(Console.ReadLine());
                        Console.WriteLine("The variable is increased by 1 = {0}", variable + 1);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("You choose string type");
                        Console.Write("Give me the variable in that type: ");
                        string variable = Console.ReadLine();
                        Console.WriteLine("The variable gets * in the end = {0}", variable + '*');
                        break;
                    }
                default:
                    break;

            }
            

        }
    }
}
