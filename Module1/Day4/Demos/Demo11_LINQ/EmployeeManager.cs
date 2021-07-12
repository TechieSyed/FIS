using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_LINQ
{
    class EmployeeManager
    {
        public static List<Employee> GetEmployees()
        {
            var Employees = new List<Employee>()
            {
                new Employee(101,"Jojo", 10000),
                new Employee(106,"Jojo", 20000),
                new Employee(102,"Sam", 12000),
                new Employee(100,"Sarah", 15000),
                new Employee(104,"Aathma", 18000),
                new Employee(103,"Elisa", 10000)
            };
            return Employees;
        }
    }
}
