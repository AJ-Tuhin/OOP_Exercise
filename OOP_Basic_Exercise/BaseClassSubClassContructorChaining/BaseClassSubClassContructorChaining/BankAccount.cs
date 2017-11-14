using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassSubClassContructorChaining
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

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
    }
}
