using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesRelationShip
{
    class Person
    {

        public double GetSalary()
        {
            double basic = 15000;
            double houseRent = 1500;

            Calculator acalculator = new Calculator();
            double totalSalary =  acalculator.Add(basic, houseRent);
            return totalSalary;
        }
    }
}
