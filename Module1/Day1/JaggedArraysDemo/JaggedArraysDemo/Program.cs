using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraysDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var collegedata = new int[3][];
            collegedata[0] = new int[3];
            collegedata[1] = new int[1];
            collegedata[2] = new int[2];

            collegedata[0][0] = 50;
            collegedata[0][1] = 50;
            collegedata[0][2] = 25;

            collegedata[1][0] = 100;

            collegedata[2][0] = 50;
            collegedata[2][1] = 50;

            for(var i = 0; i < collegedata.Length;i++)
            {
                for(var j = 0; j < collegedata[i].Length; j++)
                {
                    Console.Write(collegedata[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("College data using foreach");
            foreach(var subarray in collegedata)
            {
                foreach(var seats in subarray)
                {
                    Console.Write(seats + "\t");
                }
                Console.WriteLine();
            }

           

            Console.ReadKey();
        }
    }
}
