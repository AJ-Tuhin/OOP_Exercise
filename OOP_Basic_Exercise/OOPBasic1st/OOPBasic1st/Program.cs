using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic1st
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson =new Person();
            Console.Write("Enter your first name: ");
            aPerson.FirstName = Console.ReadLine();

            Console.Write("Enter your middle name: ");
            aPerson.MiddleName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            aPerson.LastName = Console.ReadLine();
            
            Person aPerson1 = new Person();
            Console.Write("Enter your first name: ");
            aPerson1.FirstName = Console.ReadLine();

            Console.Write("Enter your middle name: ");
            aPerson1.MiddleName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            aPerson1.LastName = Console.ReadLine();

            string fullName = aPerson.GetFullName();
            Console.WriteLine(fullName);
            string fullName1 = aPerson1.GetFullName();
            Console.WriteLine(fullName1);

            string reverseName = aPerson.GetReverseName(fullName);
            Console.WriteLine(reverseName);
            string reverseName1 = aPerson1.GetReverseName(fullName1);
            Console.WriteLine(reverseName1);

            Console.ReadKey();

        }
    }
}
