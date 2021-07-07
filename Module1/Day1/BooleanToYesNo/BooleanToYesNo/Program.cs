using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanToYesNo
{
    static class ConvertToYesNo
    {
        public static string ToYesNo(this bool bb)
        {
            return bb ? "Yes" : "No";
        }
        public static int ToInt32(this string s)
        {
            return Convert.ToInt32(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool DoYouAgreeDotNetIsBetter = false;
            string msg = DoYouAgreeDotNetIsBetter.ToYesNo();

            bool IsFreelance = true;
            Console.WriteLine("Syed is freelancer : {0}", IsFreelance.ToYesNo());

            Console.WriteLine("Do you agree with Syed? : {0}", msg);

            Console.WriteLine("Enter a number");
            int i = Console.ReadLine().ToInt32();
            Console.WriteLine("i={0}", i);
            
          
            Console.ReadKey();
        }
    }
}
