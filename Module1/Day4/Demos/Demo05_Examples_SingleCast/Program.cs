using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_Examples_SingleCast
{
    class Program
    {
        delegate bool ConditionHandler(int number);
        static void Main(string[] args)
        {
            var Numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var OddNumbersFilter = new ConditionHandler(IsOddNumber);
            var OddNumber = Filter(Numbers, OddNumbersFilter);
            foreach(var num in OddNumber)
            {
                Console.WriteLine(num);
            }


            var EvenFilter = new ConditionHandler(IsEven);
            var EvenNumbers = Filter(Numbers, EvenFilter);
            foreach(var num in EvenNumbers)
            {
                Console.WriteLine(num);
            }
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
        static bool IsOddNumber(int n)
        {
            return n % 2 != 0;
        }
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
