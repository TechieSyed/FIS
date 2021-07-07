using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i = 0; i < numbers.Length; i++)
            {                
                Console.WriteLine(numbers[i]);
            }
             
            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }

            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };
            foreach(int temp in matrix)
            {
                Console.WriteLine(temp);
            }

            Console.ReadKey();
        }
    }
}
