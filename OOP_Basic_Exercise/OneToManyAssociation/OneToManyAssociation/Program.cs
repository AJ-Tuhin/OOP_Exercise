using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course("CSE001","Computer Fandamental","3.0");
            Course course2 = new Course("CSE002", "Computer Architecture", "3.0");
            Course course3 = new Course("CSE003","Computer Lab","2.0");

            Department department1 = new Department();
            //department1.courses = new List<Course>();
            department1.courses.Add(course1);
            department1.courses.Add(course2);
            department1.courses.Add(course3);

            Console.WriteLine("Id      Name      Credit");
            foreach(Course courses in department1.courses)
            {
                Console.WriteLine(courses.Id+" - "+courses.Name+" - "+courses.Credit);
            }

            Console.ReadKey();
        }
    }
}
