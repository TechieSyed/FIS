using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print number from 1 to 10 (while)");
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
                //i = i + 1;
                //i += 1;
            }

            Console.WriteLine("Print number from 1 to 10 (do-while)");
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 10);

            Console.WriteLine("Print number from 1 to 10 (for-loop)");
            for (int k=1; k<=10; k++)
            {
                Console.WriteLine(k);
            }

            Console.ReadKey();
        }
    }
}
