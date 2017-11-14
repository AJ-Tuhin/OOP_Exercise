using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassSubClassContructorChaining
{
    class CheckingAccount:BankAccount
    {
        public double ServiceCharge { get; set; }

        public CheckingAccount(string accountNumber,string customerName,double serviceCharge)
            :base(accountNumber,customerName)
        {
            ServiceCharge = serviceCharge;
        }


    }
}
