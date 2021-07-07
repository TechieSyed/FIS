using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];
            //int[,,] matrix1 = new int[2, 2, 2];
            //matrix[0, 0] = 10;
            //matrix[0, 1] = 20;
            //matrix[1, 0] = 30;
            //matrix[1, 1] = 40;
            Console.WriteLine("Enter array elements");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col=0;col<matrix.GetLength(1); col++)
                {
                    Console.WriteLine("Enter value for row={0}, column={1}", row, col);
                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Total items : {0}", matrix.Length);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
