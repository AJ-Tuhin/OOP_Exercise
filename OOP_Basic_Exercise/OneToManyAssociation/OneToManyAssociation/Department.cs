using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociation
{
    class Department
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public string Location { set; get; }

        public List<Course> courses { set; get; }

        public Department()
        {
            courses = new List<Course>();
        }
    }
}
