using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Infrastructure;
using System.Data.Common;

namespace Demo04_EF_QueryingData
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Obtain data source
            using (var Context = new FISDemoEntities())
            {
                try
                {
                    //2. Write a query
                    //LINQ-2-OBJECTS = IENUMERABLE
                    //LINQ-2-ENTITIES = IQUERYABLE
                    var Query = from item in Context.Departments
                                orderby item.EmployeeCount descending
                                select item;

                    //3. Execute query
                    foreach (var item in Query)
                    {
                        //Console.WriteLine("Id={0}, Name={1}, EmpCount={2}", item.ID, item.Name, item.EmployeeCount);
                        Console.WriteLine(item.ToString());
                    }


                    Console.WriteLine("Employee details");
                    var Query1 = from item in Context.Employees
                                 select item;
                    foreach(var e in Query1)
                    {
                        Console.WriteLine(e.Name + "\t" + e.Salary);
                    }
                }
                catch (DbException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(DbUpdateException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
