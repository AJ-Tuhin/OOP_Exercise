using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySetGet
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public string FirstName
        {
            set
            {
                if (value.Length >= 2)
                {
                    firstName = value;
                }
            }
            get
            {
                return "Md. "+firstName;
            }
        }
        public string MiddleName
        {
            set
            {
                middleName = value;
            }
            get
            {
                return middleName;
            }
        }
        public string LastName
        {
            set
            {
                lastName = value;

            }
            get
            {
                return lastName;
            }
        }

        public Person(string firstName,string middleName,string lastName):this(firstName,lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
        public Person(string firstName,string lastName):this()
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
    }
}
