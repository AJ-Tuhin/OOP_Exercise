using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sv1 = new SavingAccount();
            Console.WriteLine(sv1.AccountNumber = "sv-01");
            Console.WriteLine(sv1.CustomerName = "Tuhin");
            Console.WriteLine(sv1.Diposite(15000));
            Console.WriteLine(sv1.Withdraw(100000));
            Console.WriteLine(sv1.Balance);

            Console.WriteLine();
            CheckingAccount ck1 = new CheckingAccount();
            Console.WriteLine(ck1.AccountNumber = "Ck-01");
            Console.WriteLine(ck1.CustomerName = "Tuhin");
            Console.WriteLine(ck1.Diposite(15000));
            Console.WriteLine(ck1.Withdraw(100000));
            Console.WriteLine(ck1.Balance);

            Console.ReadKey();
        }
    }
}
