using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    class Account
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
        }
        public void Deposit(double amount)
        {
            if(amount<=0)
            {
                var argumentException = new ArgumentException("Invalid value for amount");
                throw argumentException;
            }
            balance += amount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var account = new Account();
                Console.WriteLine("Enter amount to deposit");
                double amount = Convert.ToDouble(Console.ReadLine());
                account.Deposit(amount);
                Console.WriteLine("Balance={0}", account.Balance);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Unable to convert value");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Instance creation failed");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Message = {0}", ex.Message);
                Console.WriteLine("STACK TRACE");
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unknown error");
            }

            Console.ReadKey();
        }
    }
}
