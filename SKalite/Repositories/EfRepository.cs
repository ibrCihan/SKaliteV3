using Microsoft.EntityFrameworkCore;
using SKalite.Context;

namespace SKalite.Repositories
{
    public class EfRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly SKaliteDbContext _context;
        private readonly DbSet<T> _dbSet;
        public EfRepository(SKaliteDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public T Add(T entity)
        {
            var result = new T();
            _dbSet.Add(entity);
            _context.SaveChanges();
            result=entity;
            return result;
        }

        public T Delete(T entity)
        {
            var result =new T();
            _dbSet.Remove(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public List<T> GetAll()
        {
            var result =new List<T>();
            var list = _dbSet.ToList();
            if (list != null)
            {
                result = list;
            }
            else
            {
                result = null;
            }
            return result;
        }

        public T GetById(int id)
        {
            var result = new T();
            result = _dbSet.Find(id);
            return result;
        }

        public T UpdateById(T entity, int id)
        {
            var result = new T();
            var model = _dbSet.Find(id);
            if (model != null)
            {
                _context.Entry(model).CurrentValues.SetValues(entity);
             
                _context.SaveChanges();
                result = model;
                return result;
            }
            else
            {
                return null;
            }
            
            
        }
    }
}
