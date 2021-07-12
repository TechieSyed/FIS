using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_MultiCastDelegate
{
    class Program
    {
        delegate void PrintDelegate(string message);    //Multi-cast delegates
        static void Main(string[] args)
        {
            var p = new PrintDelegate(PrintHello);
            p = p + PrintHi;        //p+=PrintHi;   //Adding reference
            p += PrintHello;        // Adding reference

            if (p != null)
            {
                p("Jojo Jose");

                p -= PrintHello;           //removing reference
                p("Aathma");
            }
            Console.ReadKey();

        }
        static void PrintHello(string username)
        {
            Console.WriteLine("Hello : "+username);
        }
        static void PrintHi(string username)
        {
            Console.WriteLine("Hi : " + username);
        }
    }
}
