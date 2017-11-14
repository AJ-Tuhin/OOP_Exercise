using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sv1 = new SavingsAccount("sv-01","Tuhin",1500);
            sv1.Diposit(20000);
            sv1.Withdraw(150000);
            BankAccount b1 = sv1; //uppercast polymorphism
            
            //runtime polymorphism
            b1.Diposit(20000);
            Console.WriteLine(b1.Withdraw(50000));
            Console.WriteLine(b1.Balance);

            SavingsAccount sv2 = (SavingsAccount)b1; //downcast polymorphism

            Console.WriteLine(sv2.InterestAmount);

            Console.ReadKey();
        }
    }
}
