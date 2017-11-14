using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExampleApp
{
    class SavingAccount:BankAccount
    {
        public double Interest { get; set; }

        public override string Withdraw(double amount)
        {
            if (amount > Balance)
            {
                return "Insufficent Balance";
            }
            else
            {
               return base.Withdraw(amount);
            }
        }
    }
}
