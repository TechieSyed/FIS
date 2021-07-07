using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedAndOptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("C# via CLR", 10);
            Print("C# via CLR");
            Print("C# via CLR", 100);

            //Named parameters : C# 4
            Print(noOfCopies: 20, fileName: "C# via CLR");
            Console.ReadKey();
        }
        //C# version 4.0
        static void Print(string fileName, int noOfCopies = 1)
        {
            Console.WriteLine("Printing {0} copies of {1}", noOfCopies, fileName);
        }
    }
}
