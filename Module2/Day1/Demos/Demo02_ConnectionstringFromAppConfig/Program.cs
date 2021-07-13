using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
namespace Demo02_ConnectionstringFromAppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection1 = ConfigurationManager.ConnectionStrings["constr1"].ConnectionString;
            var connection2 = ConfigurationManager.ConnectionStrings["constr2"].ConnectionString;

            Console.WriteLine(connection1);
            Console.WriteLine(connection2);

            Console.ReadKey();
        }
    }
}
