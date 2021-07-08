using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08
{
    class Parent
    {
        public virtual void PrintMessage()
        {
            Console.WriteLine("hello from parent");
        }
    }
    class Child : Parent
    {
        public override void PrintMessage()
        {
            Console.WriteLine("Hello from child");
            base.PrintMessage();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var child = new Child();
            child.PrintMessage();

            Console.ReadKey();
        }
    }
}
