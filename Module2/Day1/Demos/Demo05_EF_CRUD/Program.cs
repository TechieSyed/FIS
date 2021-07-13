using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_EF_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 6)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("1. Add Department");
                Console.WriteLine("2. Delete Department");
                Console.WriteLine("3. Update Department");
                Console.WriteLine("4. Show Total Employees");
                Console.WriteLine("5. Show all departments");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\nYour choice");
                choice = Convert.ToInt32(Console.ReadLine());
                var P = new Program();
                switch (choice)
                {
                    case 1: P.AddDepartment(); break;
                    case 2: P.DeleteDepartment(); break;
                    case 3: P.UpdateDepartment(); break;
                    case 4: P.GetTotalEmployees(); break;
                    case 5: P.ShowAll(); break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private void AddDepartment()
        {
            //1. Create the object of class that need to be added
            var dept = new Department();

            //2. Assign values to the properties
            Console.WriteLine("Enter id, name, empcount");
            dept.ID = Convert.ToInt32(Console.ReadLine());
            dept.Name = Console.ReadLine();
            dept.EmployeeCount = Convert.ToInt32(Console.ReadLine());

            //3. Create the data context
            using (var Context = new FISDemoEntities())
            {
                try
                {
                    //4. Call Add() of DbSet in data context
                    Context.Departments.Add(dept);

                    //5. Call SaveChanges() on data context
                    int Rows = Context.SaveChanges();
                    Console.WriteLine("{0} rows added", Rows);

                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }

        private void DeleteDepartment()
        {
            //1. Create data context
            var Context = new FISDemoEntities();

            //2. Search DbSet for object to delete
            Console.WriteLine("Enter id to delete");
            var id = Convert.ToInt32(Console.ReadLine());

            var dept = Context.Departments.Find(id);

            //3. Call Remove() of DbSet
            if (dept == null)
            {
                Console.WriteLine("not found");
                return;
            }
            Context.Departments.Remove(dept);

            //4. Call SaveChanges() on data context
            var Rows = Context.SaveChanges();
            Console.WriteLine("{0} rows deleted", Rows);

        }

        private void UpdateDepartment()
        {
            //1. Create data context
            var Context = new FISDemoEntities();

            //2. Search for object in dbset 
            Console.WriteLine("Enter id to search");
            int id = Convert.ToInt32(Console.ReadLine());

            var dept = Context.Departments.Find(id);
            if(dept==null)
            {
                Console.WriteLine("Not found");
                return;
            }

            //3. Change values of properties
            Console.WriteLine("Enter new name and new employee count");
            dept.Name = Console.ReadLine();
            dept.EmployeeCount = Convert.ToInt32(Console.ReadLine());

            //4. Call SaveChanges() on data context
            int Rows = Context.SaveChanges();
            Console.WriteLine("{0} rows updated", Rows);
        }

        private void GetTotalEmployees()
        {
            var context = new FISDemoEntities();
            var total = context.Departments.Sum(d => d.EmployeeCount);
            Console.WriteLine("Total employees : {0}", total);
        }

        private void ShowAll()
        {
            var context = new FISDemoEntities();
            var Query = from d in context.Departments
                        select d;
            foreach(var item in Query)
            {
                Console.WriteLine(item.ID + "\t" + item.Name + "\t" + item.EmployeeCount);
            }
        }
    }
}
