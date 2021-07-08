using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        public void Printname()
        {
            Console.WriteLine("Firstname={0}, Lastname={1}", firstName, lastName);
        }
        public Person(string fname, string lname)
        {
            this.firstName = fname;
            this.lastName = lname;
        }
    }
    class Employee : Person
    {
        public int ECode { get; set; }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public Employee(int ecode, string fname, string lname) : base(fname, lname)
        {
            this.ECode = ecode;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var e = new Employee(101,"Jojo", "Jose");
         
            e.Printname();
            Console.WriteLine("ECode={0}", e.ECode);
            Console.ReadKey();
        }
    }
}
