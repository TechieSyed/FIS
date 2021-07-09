using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06
{
    class Program
    {
        static void Main(string[] args)
        {           
            //List<int> Numbers = new List<int>();
            var Numbers = new List<int>();
            Numbers.Add(10);
            Numbers.Add(30);
            Numbers.Add(20);
            Numbers.Add(50);
            Numbers.Add(40);
            //Numbers.Add("Jojo");

            int sum = 0;
            foreach(var number in Numbers)
            {
                sum = sum + number;
            }
            Console.WriteLine("Sum={0}", sum);
            Numbers.Sort();
            foreach(var number in Numbers)
            {
                Console.WriteLine(number);
            }
            var index = Numbers.BinarySearch(20);
            if (index >= 0)
            {
                Console.WriteLine("Found. Value = {0}", Numbers[index]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Numbers.Remove(10);
            Console.WriteLine("Items after removing 10 : {0}", Numbers.Count);

            Console.ReadKey();
        }
    }
}
