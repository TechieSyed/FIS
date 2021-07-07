using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Jojo", "Sam", "Sarah", "Elisa", "Aathma" };
            var result = Join('-', names);
            Console.WriteLine(result);

            var resutl1 = Join('.', "John", "Arya", "Sansa");
            Console.WriteLine(resutl1);

            Console.ReadKey();
        }
        static string Join( char separator, params string[] strings)
        {
            string result = "";
            foreach(var str in strings)
            {
                result = result + separator + str;
            }
            return result;
        }
    }
}
