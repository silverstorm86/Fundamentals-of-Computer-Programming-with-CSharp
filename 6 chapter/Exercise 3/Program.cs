using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Beolvas(ref int[] num)
        {
            
            Console.WriteLine("Give me numbers: (The exit is space)");
            string tmp = Console.ReadLine();
            while (String.Compare(tmp,"e")<0)
            {
                int[] temp = new int[num.Length+1];
                for (int i = 0; i < num.Length; i++)
                    temp[i] = num[i];
                temp[num.Length] = int.Parse(tmp);
                num = null;
                num = temp;
                tmp = Console.ReadLine();
            }
        }
        static int MaxMin(int[] num, bool bl)
        {
            int max= num[0], min = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (max < num[i] && bl)
                    max = num[i];
                if (min > num[i])
                    min = num[i];
            }

            if (bl)
                return max;
            else
                return min;
        }
        static void Main(string[] args)
        {
            int[] num = new int[0];
            Beolvas(ref num);

            Console.WriteLine("A beírt számok maximuma: " + MaxMin(num, true));
            Console.WriteLine("A beírt számok minimuma: "+MaxMin(num, false));
        }
    }
}
