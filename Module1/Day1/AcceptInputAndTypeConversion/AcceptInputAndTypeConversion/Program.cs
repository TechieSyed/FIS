using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptInputAndTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name");
            string EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter salary");
            double Salary = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Is {0} is an FIS employee?", EmployeeName);
            bool IsFISEmployee = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Employee name = " + EmployeeName);
            Console.WriteLine("Salary = " + Salary);
            Console.WriteLine("Is FIS Employee = " + IsFISEmployee);

            Console.ReadKey();
        }
    }
}
