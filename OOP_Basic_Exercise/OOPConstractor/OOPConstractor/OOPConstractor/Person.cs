using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstractor
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {
            
            MiddleName = middleName;
            
        }

        public Person(string firstName, string lastName):this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person()
        {
        }

        public string GetFullName()
        {
            string fullName = FirstName+" "+MiddleName+" "+LastName;
            return fullName;
        }

        public string GetReverseName(string text)           
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }
}
