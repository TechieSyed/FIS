using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08
{
    class Employe { }
    class Program
    {
        static void Main(string[] args)
        {
            var employeedictionary = new Dictionary<int, Employe>();
            employeedictionary.Add(101, new Employe());

            var departmentsdictdionary = new Dictionary<int, string>();
            departmentsdictdionary.Add(101, "IT");
            departmentsdictdionary.Add(102, "HR");
            departmentsdictdionary.Add(103, "Research");
            departmentsdictdionary.Add(104, "Research");
            Console.WriteLine("Total departments : " + departmentsdictdionary.Count);

            foreach(KeyValuePair<int, string> keyvalue in departmentsdictdionary)
            {
                Console.WriteLine(keyvalue.Key + " " + keyvalue.Value);
            }

            departmentsdictdionary.Remove(103);
            Console.WriteLine("Total departments after removal : {0}", departmentsdictdionary.Count);
            Console.ReadKey();
        }
    }
}
