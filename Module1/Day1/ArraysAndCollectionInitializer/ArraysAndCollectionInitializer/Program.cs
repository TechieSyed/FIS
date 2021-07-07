using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollectionInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            int[] numbers1 = new int[] { 1, 2, 3 };
            string[] usernames = new string[] { "Jojo", "Sam", "Sarah", "Aathma", "Elisa" };
            Console.WriteLine("Length of array: {0}", numbers1.Length);
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine(numbers1[i]);
            }


            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine(matrix[row, col]);
                }
            }


            Console.ReadKey();
        }
    }
}
