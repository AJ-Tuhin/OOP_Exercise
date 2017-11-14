using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociation
{
    class Course
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public string Credit { set; get; }

        public Course(string id,string name,string credit)
        {
            Id = id;
            Name = name;
            Credit = credit;
        }
    }
}
