using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    internal class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor t)
        {
            _instructorDal.Add(t);
        }

        public void Delete(int Id)
        {
            _instructorDal.Delete(Id);
        }

        public void Update(Instructor t)
        {
            _instructorDal.Update(t);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }
    }
}
