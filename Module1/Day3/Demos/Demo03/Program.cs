using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Demo03
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id={this.Id}, Name={this.Name}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[10];
            //ArrayList numbersList = new ArrayList();
            var numberslist = new ArrayList();
            numberslist.Add(10);
            numberslist.Add(30);
            numberslist.Add(20);
            numberslist.Add(100);

            var nameslist = new ArrayList();
            nameslist.Add("Jojo");
            nameslist.Add("Saray");
            nameslist.Add("Sam");
            nameslist.Add("Aathma");

            var employeeslist = new ArrayList();
            var e1 = new Employee();
            e1.Id = 101;
            e1.Name = "Jenny";
            employeeslist.Add(e1);

            var e2 = new Employee();
            e2.Id = 102;
            e2.Name = "Dan";
            employeeslist.Add(e2);

            Console.WriteLine("Total numbers : {0}", numberslist.Count);
            numberslist.Sort();
            foreach(var item in numberslist)
            {
                //int number = Convert.ToInt32(item);
                //Console.WriteLine(number);
                Console.WriteLine(item);
            }
            numberslist.Remove(30);
            Console.WriteLine("Total numbers after removing 30 : {0}", numberslist.Count);
            int indexOfItem = numberslist.BinarySearch(500);
            if (indexOfItem >= 0)
            {
                Console.WriteLine("Value found. It is {0}", numberslist[indexOfItem]);
            }
            else
            {
                Console.WriteLine("Value not found");
            }

            foreach (var name in nameslist)
            {
                string n = name.ToString();
                Console.WriteLine(n);
            }

            foreach(var emp in employeeslist)
            {
                Console.WriteLine(emp.ToString());
                //Employee e3 = emp as Employee;
                //Console.WriteLine("Id={0}, Name={1}", e3.Id, e3.Name);
            }

            Console.ReadKey();
        }
    }
}
