using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ExaminationSystem.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly Context _context;
        public Repository(Context context)
        {
            _context = context;
        }
        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }
        public void AddRange(List<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public void Delete(T entity)
        {
            entity.Deleted = true;
            Update(entity);
        }
        public void DeleteRange(IQueryable<T> entities)
        {
            //_context.RemoveRange(entities);
            foreach(var item in entities)
            {
                item.Deleted = true;
                Update(item);
            }
        }
        public IQueryable<T> GetAll()
        {
           return _context.Set<T>().Where(t=>!t.Deleted);
        }
        public IQueryable<T>GetAll(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public T? GetById(int ID,string? include=null)
        {
            IQueryable<T> query = GetAll();
            if (include != null)
                return query.Include(include).FirstOrDefault(e => e.ID == ID);
            return query.FirstOrDefault(e => e.ID == ID);

        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return entity;

        }
        public int SaveChanges()
        {
          return  _context.SaveChanges();
        }
    }
}
