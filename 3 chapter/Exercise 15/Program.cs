using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the 32 bit number where you want to do this exchange bit operation: ");
            uint num = uint.Parse(Console.ReadLine());

            uint bit3 = (num >> 3) & 1;
            uint bit24 = (num >> 24) & 1;
            num = (uint) (num & (~(1 << 24)) | (bit3 << 24));
            num = (uint) (num & (~(1 << 3)) | (bit24 << 3));

            uint bit4 = (num >> 4) & 1;
            uint bit25 = (num >> 25) & 1;
            num = (uint)(num & (~(1 << 25)) | (bit4 << 25));
            num = (uint)(num & (~(1 << 4)) | (bit25 << 4));

            uint bit5= (num >> 5) & 1;
            uint bit26 = (num >> 26) & 1;
            num = (uint)(num & (~(1 << 26)) | (bit5 << 26));
            num = (uint)(num & (~(1 << 5)) | (bit26 << 5));

            Console.WriteLine("The new number is :"+num);




        }
    }
}
