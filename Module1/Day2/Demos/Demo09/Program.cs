using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09
{
    abstract class Parent
    {
        public abstract void PrintMessage();
        public void DoWork()
        {
            Console.WriteLine("Parent working...");
        }
    }
    class Child : Parent
    {
        public override void PrintMessage()
        {
            Console.WriteLine("Print message overriden");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var child = new Child();
            child.PrintMessage();
            child.DoWork();

            //var parent = new Parent();
            //parent.PrintMessage();

            Console.ReadKey();
        }
    }
}
