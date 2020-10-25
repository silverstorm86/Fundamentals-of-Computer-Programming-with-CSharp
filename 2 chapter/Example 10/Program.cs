using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Literals

            //Integer Literals :
            //The following variables are initalized with the same value
            int numberInDec = 16;
            int numberInHex = 0x10;
            

            //Real Literals :
            //The following is the correct way of assigning a value
            float realNumber = 12.5f;
            //This is the same value in exponential format
            realNumber = 1.25e+1f;
            double realNumber2 = 12.5d;
            decimal realNumber3 = 12.5m;

            //Character Literals :
            //Ordinary character
            char character = 'a';
            //Unicode character code in a hexadecimal format
            character = '\u003A';
            // Assigning the single quotiation character (escaped as \')
            character = '\'';

            //String Literals :
            string quotation = "\"Hello, Jide\",he said.";

                                                                        
        }
    }
}
