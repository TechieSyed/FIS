using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithVariables
{

    class Program
    {
        static void Main(string[] args)
        {            
            string EmployeeName = "Jojo";
            int EmployeeCode = 10234;
            bool IsFIS_Employee = false;
            double Salary = 10000.50;

            Console.WriteLine("Employee Name = {0}", EmployeeName);
            Console.WriteLine("Employee Code = {0}", EmployeeCode);
            Console.WriteLine("Employee Is FIS Employee = {0}", IsFIS_Employee);
            Console.WriteLine("Employee Salary = {0}", Salary);
            Console.WriteLine("Name = {0}, Code= {1},  FIS Employee : {2}, Salary = {3}", EmployeeName, EmployeeCode, IsFIS_Employee, Salary);
            Console.WriteLine("Name = " + EmployeeName + " Code = " + EmployeeCode + " Fis employee = " + IsFIS_Employee + " Salary = " + Salary);
            //Works only on C# version 7 onwards
            Console.WriteLine($"Name={EmployeeName}, Code={EmployeeCode}, FIS Employee={IsFIS_Employee}, Salary={Salary}");

            Console.ReadKey();
            
        }
    }
}
