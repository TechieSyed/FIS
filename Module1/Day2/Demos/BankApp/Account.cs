using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public abstract class Account : IBankOperations
    {
        //Attributes
        private int accountNo;
        public int AccountNo
        {
            get { return this.accountNo; }
            set { this.accountNo = value; }
        }
       
        private double balance;
        public double Balance
        {
            get { return this.balance; }
        }
       
        public string CustomerName { get; set; }

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
        public void Deposit(Cheque cheque)
        {
            balance = balance + cheque.Amount;
            cheque.Status = ChequeStatus.Cleared;
        }
        public virtual void Withdraw(double amount)
        {
            balance = balance - amount;
        }
        public abstract string GetAccountDetails();



        private static string bankName;
        static Account()
        {
            bankName = "Xyz Bank";
        }
        public static string BankName
        {
            get { return bankName; }
        }
        public static void ChangeBankName(string newBankName)
        {
            bankName = newBankName;
        }


    }
}
