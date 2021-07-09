using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Demo
    {
        public void DoWork()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numerator, denominator, result;

            try
            {
                Console.WriteLine("Enter numerator");
                numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter denominator");
                denominator = Convert.ToInt32(Console.ReadLine());

                result = numerator / denominator;

                Console.WriteLine("Result = {0}", result);

                var ex = new NotImplementedException();
                throw ex;

                //Demo d = null;
                //d.DoWork();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error dividing numbers");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Unable to convert to a number");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unknown error during execution");
            }
            finally
            {
                Console.WriteLine("Press any key to terminate....");
            }

            Console.ReadKey();
        }
    }
}
