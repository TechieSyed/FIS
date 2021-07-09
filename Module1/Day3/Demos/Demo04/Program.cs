using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable table = new Hashtable();
            var table = new Hashtable();
            table.Add(101, "John");
            table.Add(103, "Jenny");
            table.Add(102, "Jojo");
            Console.WriteLine("Total items : {0}", table.Count);
            foreach(DictionaryEntry entry in table)
            {
                Console.WriteLine(entry.Key);
                Console.WriteLine(entry.Value);
            }

            table.Remove(102);
            Console.WriteLine("Total items after removing 102 : {0}", table.Count);

            Console.ReadKey();
        }
    }
}
