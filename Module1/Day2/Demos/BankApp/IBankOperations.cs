﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    interface IBankOperations
    {
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
