using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySetGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Person person1 = new Person();
            person1.FirstName = firstName;
            person1.MiddleName = middleName;
            person1.LastName = lastName;

            Console.WriteLine(person1.GetFullName());
            //Console.WriteLine(person1.FirstName);
            Console.ReadKey();
        }
    }
}
