using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDimensionArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers;  //declare
            //numbers = new int[5]; //instantiation

            //declare and instantiate
            int[] numbers = new int[5];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[4] = 50;
            for(int index=0;index<numbers.Length; index++)
            {
                Console.WriteLine("Enter the element at {0} index", index);
                numbers[index] = Convert.ToInt32( Console.ReadLine());
            }

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);
            Console.WriteLine("Total elements : {0}", numbers.Length);
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
