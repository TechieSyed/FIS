using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_LamdaExpression_01
{
    class Program
    {
        delegate bool ConditionHandler(int number);
        static void Main(string[] args)
        {
            var Numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //var OddNumber = Filter(Numbers, x => x % 2 != 0);
            //var OddNumber = Filter(Numbers, (int n) => { return n % 2 != 0; });
            //var OddNumber = Filter(Numbers,  n => { return n % 2 != 0; });
            var OddNumber = Filter(Numbers, (int n) => n % 2 != 0);
            foreach (var num in OddNumber)
            {
                Console.WriteLine(num);
            }

            var EvenNumbers = Filter(Numbers, n => n % 2 == 0);
            foreach (var num in EvenNumbers)
            {
                Console.WriteLine(num);
            }

            var NumberBiggerThan5 = Filter(Numbers, n => n > 5 && n <= 8);
            foreach (var num in NumberBiggerThan5)
            {
                Console.WriteLine(num);
            }
            //Action<int, string> obj = (x, y) => { };
           
            Console.ReadKey();
        }
        static List<int> Filter(List<int> input, ConditionHandler condition)
        {
            var output = new List<int>();
            foreach (var number in input)
            {
                if (condition(number))
                {
                    output.Add(number);
                }
            }
            return output;
        }

    }
}
