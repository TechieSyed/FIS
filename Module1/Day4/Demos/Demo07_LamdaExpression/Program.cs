using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07_LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> CheckAndPrintEven = x =>
            {
                if (x % 2 == 0)
                    Console.WriteLine("{0} is even", x);
                else
                    Console.WriteLine("{0} is not even", x);

            };
            CheckAndPrintEven(9);

            Predicate<int> IsEvenCheck = n => n % 2 == 0; 
            var result = IsEvenCheck(8);
            Console.WriteLine("8 is even {0}", result);

            Func<int, string> GetEvenResult = number => number % 2 == 0 ? $"{number} is even" : $"{number} is odd";
            var message = GetEvenResult(7);
            Console.WriteLine(message);

            Console.ReadKey();
        }
      
        
       
    }
}
