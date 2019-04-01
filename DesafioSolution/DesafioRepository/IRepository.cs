using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioRepository
{
    public interface IRepository<T>
    {
        T Get(int key);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
    }
}
