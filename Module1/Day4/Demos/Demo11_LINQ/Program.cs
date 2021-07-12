using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Obtain data source
            var DataSource = EmployeeManager.GetEmployees();

            //2. Write linq query
            //var Result = from item in DataSource
            //             select item;

            ////Ordered based on Name
            //var Result = from item in DataSource
            //             orderby item.Name
            //             select item;

            ////Ordered based on Name and salary in descending
            //var Result = from item in DataSource
            //             orderby item.Name, item.Salary descending
            //             select item;

            //Get employees based on salary more than 12000, order based on Name
            var Result = from item in DataSource
                         where item.Salary > 12000
                         orderby item.Name
                         select item;

            //3. Executing query
            foreach (var r in Result)
            {
                Console.WriteLine(r);
            }

            Console.ReadKey();
        }
    }
}
