using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface MyService<T>
    {
        void Add(T t);
        void Update(T t);
        void Delete(int Id);
        List<T> GetAll();
    }
}
