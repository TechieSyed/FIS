using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07
{
    class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee other)
        {
            //return 0 for equal
            //current > other return 1
            //current < other return -1
            //if (this.Id == other.Id)
            //    return 0;
            //else if (this.Id > other.Id)
            //    return 1;
            //else
            //    return -1;
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return this.Id + "\t" + this.Name;
        }
    }
    class Program
    {
        static List<Employee> EmployeesList = new List<Employee>();

        static void Main(string[] args)
        {
            int choice = -1;
            do
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("1.Add employee");
                Console.WriteLine("2.Show all");
                Console.WriteLine("3.Search");
                Console.WriteLine("4.Remove");
                Console.WriteLine("5.Update");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddEmployee(); break;
                    case 2: ShowEmployees(); break;
                    case 3: SearchEmployee(); break;
                    case 4: RemoveEmployee(); break;
                    case 5: UpdateEmployee(); break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 0);
        }

        private static void UpdateEmployee()
        {
            var e = new Employee();
            Console.WriteLine("Enter id to edit");
            e.Id = Convert.ToInt32(Console.ReadLine());

            int index = EmployeesList.BinarySearch(e);
            if (index < 0)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("Enter new name");
                EmployeesList[index].Name = Console.ReadLine();
                Console.WriteLine("Employee updated");
            }
        }

        private static void RemoveEmployee()
        {
            var e = new Employee();
            Console.WriteLine("Enter id to remove");
            e.Id = Convert.ToInt32(Console.ReadLine());

            int index = EmployeesList.BinarySearch(e);
            if (index < 0)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                EmployeesList.RemoveAt(index);
                Console.WriteLine("Employee removed. Current count : {0}", EmployeesList.Count);
            }
        }

        private static void SearchEmployee()
        {
            Console.WriteLine("Enter id to search");
            int id = Convert.ToInt32(Console.ReadLine());
            var e = new Employee();
            e.Id = id;
            int index = EmployeesList.BinarySearch(e);
            if (index < 0)
            {
                Console.WriteLine("No employee found for id={0}", id);
            }
            else
            {
                Console.WriteLine("Employee found: Employee details : {0}", EmployeesList[index]);
            }
        }

        private static void ShowEmployees()
        {
            Console.WriteLine("Total employees in the list is : {0}", EmployeesList.Count);
            Console.WriteLine("Id\tName");
            Console.WriteLine("--------------------------");
            foreach (var e in EmployeesList)
            {
                //Console.WriteLine("Id={0}, Name={1}", e.Id, e.Name);
                Console.WriteLine(e);
            }
        }

        private static void AddEmployee()
        {
            var e = new Employee();

            Console.WriteLine("Enter id");
            e.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name");
            e.Name = Console.ReadLine();

            EmployeesList.Add(e);
            Console.WriteLine("Added. Total items in list : {0}", EmployeesList.Count);
        }
    }
}
