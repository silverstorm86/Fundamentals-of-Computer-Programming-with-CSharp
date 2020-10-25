using System;

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me the 32 bit number, where you want to do this exchange bit operation: ");
            uint num = uint.Parse(Console.ReadLine());

            uint pBit;
            uint qBit;

            for (int i = 1; i <= 16; i++)
            {
                pBit = (num >> i) & 1;
                qBit = (num >> (i + 16)) & 1;
                num = (uint)(num & (~(1 << (i + 16))) | (pBit << (i + 16)));
                num = (uint)(num & (~(1 << i)) | (qBit << i));
            }

            Console.WriteLine("New number is: " + num);
        }
    }
}
