using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace Demo05
{
    //PROBLEMS
    //Type casting (implict when adding, explicity while retrieval)
    //Not typesafe
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new ArrayList();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);
            numbers.Add("Jojo");

            int sum = 0;
            foreach (var number in numbers)
            {
                sum = sum + Convert.ToInt32(number);
            }
            Console.WriteLine("Sum={0}", sum);

            Console.ReadKey();
        }
    }
}
