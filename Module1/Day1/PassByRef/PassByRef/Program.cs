using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 20;
            
            Console.WriteLine("Values of x={0} & y={1} before swap", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("Values of x={0} & y={1} after swap", x, y);

            //int a, b = 10;
            //Swap(ref a, ref b);
            Console.ReadKey();

        }

        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Values of a={0} & b={1} inside swap", a, b);
        }
    }
}
