using CleanArchitecture.DataAccess.Concretes;
using CleanArchitecture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Business;

public class CourseManager
{
    private readonly CourseDal _courseDal;

    public CourseManager(CourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }
}