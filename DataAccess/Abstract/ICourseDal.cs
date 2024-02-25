using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll(Func<object, bool> value);
        void Add (Course course);
        void Update(Course course);
        void Delete(Course course);
        List<Course> GetAll();
        void Delete(int ıd);
    }
}
