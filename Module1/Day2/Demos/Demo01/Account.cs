using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Account
    {
        //Attributes
        public int accountNo;
        public double balance;

        //methods
        public void Deposit(double amount)
        {
            balance = balance + amount;
        }
        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }
    }
}
