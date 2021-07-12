using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_FunActionPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> CheckAndPrintEven = new Action<int>(EvenCheck);
            CheckAndPrintEven(9);

            Predicate<int> IsEvenCheck = new Predicate<int>(EvenCheck1);
            var result = IsEvenCheck(8);
            Console.WriteLine("8 is even {0}", result);

            Func<int, string> GetEvenResult = new Func<int, string>(EvenCheck2);
            var message = GetEvenResult(7);
            Console.WriteLine(message);

            Console.ReadKey();
        }
        static void EvenCheck(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine("{0} is even", number);
            else
                Console.WriteLine("{0} is not even", number);
        }
        static bool EvenCheck1(int number)
        {
            return number % 2 == 0;
        }
        static string EvenCheck2(int number)
        {
            if (number % 2 == 0)
                return number + " is even";
            else
                return number + " is not even";
        }
    }
}
