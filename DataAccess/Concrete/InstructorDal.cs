using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructor;

        public InstructorDal()
        {
            _instructor = new List<Instructor>()
        {
            new Instructor { Id = 1, FirstName = "Ahmet", LastName = "Yılmaz" },
            new Instructor { Id = 2, FirstName = "Hasan", LastName = "Çağlar" },
            new Instructor { Id = 3, FirstName = "Hüseyin", LastName = "Yıldırım" }
        };
        }

        public void Add(Instructor ınstructor)
        {
            _instructor.Add(ınstructor);
        }

        public void Delete(Instructor ınstructor)
        {
            Instructor instructorToDelete = _instructor.SingleOrDefault(i => i.Id == ınstructor.Id);
            _instructor.Remove(instructorToDelete);
        }

        public List<Instructor> GetAll()
        {
            return _instructor.ToList();
        }

        public void Update(Instructor ınstructor)
        {
            Instructor instructorToUpdate = _instructor.SingleOrDefault(i => i.Id == ınstructor.Id);
            instructorToUpdate.FirstName = ınstructor.FirstName;
            instructorToUpdate.LastName = ınstructor.LastName;
        }
    }
}
