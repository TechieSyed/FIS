using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            DateTime doj;
            var username = GetUserDetails(out age, out doj);
            Console.WriteLine("Username entered is : {0}", username);
            Console.WriteLine("Age entered is : {0}", age);
            Console.WriteLine("Date of joining entered is : {0}", doj.ToString("d"));

            Console.ReadKey();
        }
        static string GetUserDetails(out int age, out DateTime dateOfJoining)
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter date of joining");
            dateOfJoining = Convert.ToDateTime(Console.ReadLine());

            return username;
        }
    }
}
