using CleanArchitecture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.DataAccess.Concretes
{
    public class CourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course
            {
                Id = 1,
                Name = "C# ",
                Instructor = "Engin Demiroğ",
                Description = ".NET 8 vs...",
                Price = 100,
                Capacity = 20
            };
            Course course2 = new Course
            {
                Id = 2,
                Name = "JAVA",
                Instructor = "Engin Demiroğ",
                Description = "Java 17 ...",
                Price = 200,
                Capacity = 50
            };  
            Course course3 = new Course
            {
                Id = 3,
                Name = "Python",
                Instructor = "Engin Demiroğ",
                Description = "Python 3.12...",
                Price = 50,
                Capacity = 10
            };
           courses = new List<Course> { course1, course2, course3 };

        }
        public List<Course> GetAll()
        {
            return courses;
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }
    }
}
