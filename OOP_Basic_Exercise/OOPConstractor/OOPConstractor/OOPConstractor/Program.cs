using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Al","Jobaed","Tuhin");
            //Console.Write("Enter your First name: ");
            //person1.FirstName = Console.ReadLine();
            Console.WriteLine(person1.GetFullName());
            Console.WriteLine(person1.GetReverseName(person1.GetFullName()));
            
            
            Console.ReadKey();

        }
    }
}
