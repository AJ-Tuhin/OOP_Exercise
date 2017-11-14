using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class SavingsAccount :BankAccount
    {
        public double InterestAmount { get; set; }

        public SavingsAccount(string accountNumber,string customerName,double interestAmount)
            :base(accountNumber, customerName)
        {
            InterestAmount = interestAmount;
        }

        public override string Withdraw(double amount)
        {
            if (amount > Balance)
            {
                return "Insufficent balance";
            }
            return base.Withdraw(amount);
        }
    }
}
