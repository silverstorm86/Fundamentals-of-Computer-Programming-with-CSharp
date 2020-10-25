using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string csharp = "C#";
            string dotnet = ".NET";
            string csharpDotNet = csharp + dotnet;
            Console.WriteLine(csharpDotNet); //C#.NET
            string csharDotNet4 = csharpDotNet + " " + 5;
            Console.WriteLine(csharDotNet4);
        }
    }
}
