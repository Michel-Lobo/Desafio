using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioService
{
    public interface IServiceBase<T> where T :class
    {
        T Get(int key);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
    }
}
