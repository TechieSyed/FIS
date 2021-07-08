using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Adder
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public string Add(string x, string y)
        {
            return x + y;
        }
        //public string Add(int x, int y)
        //{
        //    return (x + y).ToString();
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adder ad = new Adder();
            var result = ad.Add(101, 102);
            var result1 = ad.Add("Jojo", "Jose");
           
            Console.WriteLine(result);
            Console.WriteLine(result1);
         
            Console.ReadKey();
        }
    }
}
