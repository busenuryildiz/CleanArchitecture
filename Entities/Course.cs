using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCQRS.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
        public int Credit { get; set; }
        public int Capacity { get; set; }
        public int Enrolled { get; set; }
    }

}
