using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Account account;            //declared an object
            //account = new Account();    //instance creation

            Account account = new Account();
            account.accountNo = 101;
            account.balance = 1000;
            Console.WriteLine("Intial balance = {0}", account.balance);
            account.Deposit(500);
            Console.WriteLine("New balance after deposit = {0}", account.balance);
            account.Withdraw(800);
            Console.WriteLine("New balance after withdraw = {0}", account.balance);

            Console.ReadKey();
        }
    }
}
