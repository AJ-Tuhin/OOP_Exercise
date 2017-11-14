using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }


        public BankAccount(string accountNumber,string customerName)
            :this()
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
        }
        public BankAccount()
        {
            Balance = 0;
        }
        public string Diposit(double amount)
        {
            Balance += amount;
            return "Diposited";
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdraw successful";
        }
    }
}
