using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_FunActionPredicate_LamdaExpression
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(int id, string name, double salary)
        {
            this.ID = id;
            this.Name = name;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return this.ID + " \t " + this.Name + "\t" + this.Salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Employees = new List<Employee>()
            {
                new Employee(101,"Jojo", 10000),
                new Employee(102,"Sam", 12000),
                new Employee(100,"Sarah", 15000),
                new Employee(104,"Aathma", 18000),
                new Employee(103,"Elisa", 10000)
            };

            foreach (var e in Employees)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Names starting with S");
            //var EList1 = Employees.Where(GetByNameStartingWithS);
            var EList1 = Employees.Where(emp => emp.Name.StartsWith("S"));
            foreach (var e in EList1)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Employees with salary between 12000 and 18000");
            var Elist2 = Employees.Where(x => x.Salary >= 12000 && x.Salary <= 18000);
            foreach(var e in Elist2)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Employees sorted based on names");
            var Elist3 = Employees.OrderBy(e => e.Name);
            foreach(var e in Elist3)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Display employees with salary greater than 12000 in ascending order of salary");
            var Elist4 = Employees.Where(x => x.Salary > 12000).OrderBy(x => x.Salary);
            foreach(var e in Elist4)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Display the first employee whose name starts with S");
            var Emp = Employees.First(e => e.Name.StartsWith("S"));
            Console.WriteLine(Emp);

            Console.WriteLine("Display details of employee with ID=100");
            var Emp1 = Employees.Find(e => e.ID == 100);
            Console.WriteLine(Emp1);

            Console.ReadKey();
        }
        static bool GetByNameStartingWithS(Employee e)
        {
            return e.Name.StartsWith("S");
        }
    }
}
