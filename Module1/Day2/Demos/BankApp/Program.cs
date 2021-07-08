using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AccountClassCode
            //Account obj = new Account(101, 500);
            //Console.WriteLine("Bank Name={0}", Account.BankName);
            //obj.CustomerName = "Jojo Jose";
            //Console.WriteLine("Customer name = {0}", obj.CustomerName);
            //Console.WriteLine("Account No={0}, Balance={1}", obj.AccountNo, obj.Balance);

            //obj.Deposit(1000);
            //Console.WriteLine("After 1000 deposit Account No={0}, Balance={1}", obj.AccountNo, obj.Balance);

            //obj.Withdraw(1000);
            //Console.WriteLine("After 300 withdraw Account No={0}, Balance={1}", obj.AccountNo, obj.Balance);

            ////obj.Balance = 50000;
            //var cheque = new Cheque();
            //cheque.Amount = 5000;
            //cheque.AccountNo = 102;
            //cheque.BankName = "Xyz Bank";
            //cheque.BeneficiaryName = "Jojo Jose";
            //cheque.Date = DateTime.Now;
            //cheque.IFSC_Code = "XYZ1234";

            //obj.Deposit(cheque);
            //Console.WriteLine("After cheque deposit Account No={0}, Balance={1}", obj.AccountNo, obj.Balance);
            #endregion

            var sa = new SavingsAccount(DateTime.Now.AddYears(-23), 10001, 10000);
            sa.CustomerName = "Jojo Jose";

            sa.Withdraw(5000);           

            var accountDetails = sa.GetAccountDetails();
            Console.WriteLine(accountDetails);

            Console.ReadKey();
        }
    }
}
