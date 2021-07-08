using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class SavingsAccount : Account
    {
        public DateTime DateOfBirth { get; set; }
        public SavingsAccount() : base()
        {

        }
        public SavingsAccount(int accountNo) : base(accountNo)
        {

        }
        public SavingsAccount(int accountNo, double initalBalance) : base(accountNo, initalBalance)
        {

        }
        public SavingsAccount(DateTime dateOfBirth, int accountNo, double initalBalance) : base(accountNo, initalBalance)
        {
            this.DateOfBirth = dateOfBirth;
        }

        public override void Withdraw(double amount)
        {
            if (base.Balance - amount >= 500)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Minimum balance needs to be maintained");
            }
        }

        public override string GetAccountDetails()
        {
            return $"Account No={base.AccountNo}\nCustomer Name={base.CustomerName}\nBalance={base.Balance}\nDate of Birth={this.DateOfBirth.ToString("d")}";
        }
    }
}
