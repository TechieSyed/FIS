using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06
{
    class Employee
    {
        private string employeeName;
        private static string companyName;
        public static string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public static void ChangeName(string newName)
        {
            companyName = newName;
        }
        static Employee()
        {
            companyName = "FIS Global";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee();

            e.EmployeeName = "Jojo";
            Console.WriteLine("Company name={0}", Employee.CompanyName);
            Employee.ChangeName("Cognizant");
            Console.WriteLine("Company name={0}", Employee.CompanyName);

        }
    }
}
