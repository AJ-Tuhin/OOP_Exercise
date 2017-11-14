using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassSubClassContructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sv1 = new SavingsAccount("sv-01","Tuhin",1500);
            Console.WriteLine(sv1.Balance);

            CheckingAccount ck1 = new CheckingAccount("ck-01", "Aj Tuhin", 5000);
            Console.WriteLine(ck1.Balance);

            Console.ReadKey();
        }
    }
}
