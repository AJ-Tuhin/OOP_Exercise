using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExampleApp
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }

        public string Diposite(double amount)
        {
            Balance += amount;
            return "Diposite successfull";
        }
        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdraw successfull";
        }
    }
}
