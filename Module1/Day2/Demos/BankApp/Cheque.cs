using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Cheque
    {
        public string ChequeNo { get; set; }
        public string BeneficiaryName { get; set; }
        public int AccountNo { get; set; }
        public double Amount { get; set; }
        public string IFSC_Code { get; set; }
        public DateTime Date { get; set; }
        public string BankName { get; set; }
        public ChequeStatus Status { get; set; }
    }
}
