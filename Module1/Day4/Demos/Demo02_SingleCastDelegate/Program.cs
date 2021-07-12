using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_SingleCastDelegate
{
    class Program
    {
        delegate string MessageDelegate(string username);       //Single-Cast delegates
        static void Main(string[] args)
        {
            var delObj = new MessageDelegate(SayHello);
            var result = delObj("Jojo Jose");
            Console.WriteLine(result);

            delObj = SayHi;
            result = delObj("Sarah");
            Console.WriteLine(result);

            Console.ReadKey();

        }
        static string SayHello(string username)
        {
            return "Hello !! " + username;
        }
        static string SayHi(string username)
        {
            return "Hi " + username + " !!";
        }
    }
}
