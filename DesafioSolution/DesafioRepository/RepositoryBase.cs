using DesafioDataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DesafioRepository
{
    public class RepositoryBase<Entity> : IDisposable, IRepository<Entity> where Entity: class {

        private DesafioContext _context;
        private DbSet<Entity> _dbSet;
        public RepositoryBase(DesafioContext context)
        {
            _context = context;
            _dbSet = context.Set<Entity>();
        }
        public void Add(Entity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Entity entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
            else
            {
                GC.SuppressFinalize(_context);
            }
        }

        public Entity Get(int key)
        {
            return _dbSet.Find(key);
        }

        public IQueryable<Entity> GetAll()
        {

            return _context.Set<Entity>();
        }

        public void Update(Entity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;


        }

        public void Commit()
        {
            _context.SaveChanges();
        }


    }
    
}
