using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_LINQ
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
}
