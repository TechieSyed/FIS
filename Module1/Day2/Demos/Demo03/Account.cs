using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public class Account
    {
        //Attributes
        public int accountNo;
        public double balance;

        public Account()    //Default constructor
        {
            this.balance = 500;
        }     
        public Account(int accountNo)   //parameterized constructor
        {
            this.accountNo = accountNo;
            this.balance = 500;
        }
        public Account(int accountNo, double initalBalance)  //parameterized constructor
        {
            this.accountNo = accountNo;
            this.balance = initalBalance;
        }

        //Methods
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
