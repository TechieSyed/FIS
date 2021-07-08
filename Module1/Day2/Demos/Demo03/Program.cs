using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Console.WriteLine("Balance for account = {0}", account.balance);

            Account account1 = new Account(101);
            Console.WriteLine("Account No={0}, Balance={1}", account1.accountNo, account1.balance);

            Account account2 = new Account(102, 1000);
            Console.WriteLine("Account No={0}, Balance={1}", account2.accountNo, account2.balance);

            Console.ReadKey();
        }
    }
}
