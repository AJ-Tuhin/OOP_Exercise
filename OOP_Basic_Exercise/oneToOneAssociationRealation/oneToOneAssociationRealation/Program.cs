using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneToOneAssociationRealation
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("101","2","5870","Bogra");

            Person aperson = new Person(address1);
            //string fullAddress = address1.GetFullAddress();
            //Console.WriteLine(fullAddress);
            Console.WriteLine(aperson.PersonAddress.GetFullAddress());
            Console.ReadKey();
            
        }
    }
}
