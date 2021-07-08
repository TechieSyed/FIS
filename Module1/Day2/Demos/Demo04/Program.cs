using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Person
    {
        public string Address { get; private set; } //asymetric-implemented
        public string Gender { get; set; }      //auto-implemented
        public string firstName;
        private string lastName;
        public string LastName
        {
            get
            {
                if(lastName==null || lastName.Length==0)
                {
                    return "Not specified";
                }    
                return lastName;
            }
            set
            {
                if (value.Length > 0)
                {
                    lastName = value;
                }
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 58)
                {
                    age = value;
                }
                else
                {
                    age = 18;
                }
            }
        }
        public string FullName      //read-only property
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.firstName = "Jojo";
            p.LastName = "Jose";
            p.Age = 500;
            Console.WriteLine(p.GetFullName());
            Console.WriteLine(p.Age);

            //p.FullName = "Jojo Jose";   //Fullname is readonly
            Console.WriteLine(p.FullName);

            //p.Address = "Kochin";
            p.Gender = "Male";
            Console.WriteLine(p.Address);
            Console.WriteLine(p.Gender);
            Console.ReadKey();
        }
    }
}
