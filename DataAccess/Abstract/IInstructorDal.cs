using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IInstructorDal 
    {
        List<Instructor> GetAll();
        void Add(Instructor ınstructor);
        void Update(Instructor ınstructor);
        void Delete(Instructor ınstructor);
    }
} 
