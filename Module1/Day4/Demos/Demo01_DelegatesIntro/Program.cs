using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_DelegatesIntro
{
    class Messanger
    {
        public void PrintHi()
        {
            Console.WriteLine("Hi !!");
        }
    }
    
    class Program
    {
        //<modifier> delegate <return-type>  <NameOfDelegateType>(<parameters>); 
        delegate void MessageDelegate();

        static void Main(string[] args)
        {
            ////create an object
            //MessageDelegate del;

            ////create an instance
            //del = new MessageDelegate(PrintHello);

            var del = new MessageDelegate(PrintHello);
            del();

            var messenger = new Messanger();
            var del1 = new MessageDelegate(messenger.PrintHi);
            del1();

            Console.ReadKey();
        }
        static void PrintHello()
        {
            Console.WriteLine("Hello !!");
        }
    }
}
