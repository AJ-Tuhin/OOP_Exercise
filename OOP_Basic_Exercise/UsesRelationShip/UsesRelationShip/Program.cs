using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesRelationShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aperson = new Person();
            double salary = aperson.GetSalary();
            Console.WriteLine(salary);
            Console.ReadKey();

        }
    }
}
