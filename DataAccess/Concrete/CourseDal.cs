using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _course;

        public CourseDal()
        {
            _course = new List<Course>
            {

        new Course { CourseId = 1, CourseName = "C# + Angular", CourseDescription = "Yazılım Geliştirici Yetiştirici Kampı (C# + Angular)", CategoryId = 1, InstructorId = 1 },
        new Course { CourseId = 2, CourseName = "Javascript", CourseDescription = "Yazılım Geliştirici Yetiştirici Kampı (Javascript)", CategoryId = 1, InstructorId = 1 },
        new Course { CourseId = 3, CourseName = "Java + React", CourseDescription = "Yazılım Geliştirici Yetiştirici Kampı (Java + React)", CategoryId = 1, InstructorId = 1 },
        new Course { CourseId = 4, CourseName = ".Net", CourseDescription = "Senior Yazılım Geliştirici Kampı (.Net)", CategoryId = 1, InstructorId = 1 }

            };
        }


        public void Add(Course course)
        {
            _course.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseToDelete = _course.SingleOrDefault(c => c.CourseId == course.CourseId); //use LINQ

            _course.Remove(courseToDelete);
        }

        public List<Course> GetAll()
        {
            return _course;
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _course.SingleOrDefault(c => c.CourseId == course.CourseId); //use LINQ
            courseToUpdate.CourseName = course.CourseName;
            courseToUpdate.CourseId = course.CourseId;
            courseToUpdate.CourseDescription = course.CourseDescription;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
        }

        public List<Course> GetAllByCategory(int CategoryID)
        {

            return _course.Where(c => c.CategoryId == CategoryID).ToList();

        }

    }
}
