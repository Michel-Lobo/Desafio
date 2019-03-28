using DesafioDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioRepository;
namespace DesafioService
{
    public class ServiceBase<Entity> : IServiceBase<Entity> where Entity : class
    {
        DesafioContext _context = new DesafioContext();
        IRepository<Entity> _repositoty;

        public ServiceBase()
        {
            _repositoty = new RepositoryBase<Entity>(_context);
        }
        public void Add(Entity entity)
        {
            _repositoty.Add(entity);
            
        }

        public void Delete(Entity entity)
        {
            _repositoty.Delete(entity);
        }

        public Entity Get(int key)
        {
            return _repositoty.Get(key);
        }

        public IQueryable<Entity> GetAll()
        {
            return _repositoty.GetAll();
        }

        public void Update(Entity entity)
        {
            _repositoty.Update(entity);
        }
    }
}
