using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the company name : ");
            string company = Console.ReadLine();
            Console.Write("Give me the address : ");
            string address = Console.ReadLine();
            Console.Write("Give me the phone number : ");
            int phone = int.Parse(Console.ReadLine());
            Console.Write("Give me the fax number : ");
            int fax = int.Parse(Console.ReadLine());
            Console.Write("Give me the website : ");
            string web = Console.ReadLine();
            Console.Write("Give me the managers name : ");
            string manName = Console.ReadLine();
            Console.Write("Give me the managers surname : ");
            string manSur = Console.ReadLine();
            Console.Write("Give me the managers phone : ");
            int mPhone = int.Parse(Console.ReadLine());

            Console.WriteLine("Here is all the information that you entered");
            Console.WriteLine("{0}\n{1}\n{2:(0#) ### ## ##}\n{3:(0#) ### ## ##}\n{4}\n{5} {6}\n{7:(0##) ### ## ##}", 
                company, address, phone, fax, web, manName, manSur, mPhone);
        }
    }
}
