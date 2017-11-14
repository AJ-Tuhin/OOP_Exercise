using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneToOneAssociationRealation
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Address PersonAddress { get; set; }


        public Person(string fName,string mName,string lName,Address personAddress) :this(fName,lName,personAddress)
        {
            MiddleName = mName;
        }
        public Person(string fName,string lName,Address personAddress) :this(personAddress)
        {
            FirstName = fName;
            LastName = lName;
        }
        public Person(Address personAddress)
        {
            PersonAddress = personAddress;
        }
        public string GetFullName()
        {
            string fullName = FirstName+" "+MiddleName+" "+LastName+" "+PersonAddress;
            return fullName;
        }
    }
}
