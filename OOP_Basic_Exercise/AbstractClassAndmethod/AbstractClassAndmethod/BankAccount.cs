using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndmethod
{
    abstract class BankAccount
    {

        public abstract void Transfer(string from, string to, double amount);
    }
}
