using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassSubClassContructorChaining
{
    class SavingsAccount:BankAccount
    {
        public double InterestAmount{ get; set; }

        public SavingsAccount(string accountNumber,string customerName,double interestAmount)
            : base(accountNumber, customerName)
        {
            InterestAmount = interestAmount;
        }
    }
}
