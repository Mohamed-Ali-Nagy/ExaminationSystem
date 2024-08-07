using System.Linq.Expressions;

namespace ExaminationSystem.Repository
{
    public interface IRepository<T>
    {
        public T GetById(int ID,string include=null);
        public IQueryable<T> GetAll();
        public void AddRange(List<T> entities);
        public T Add(T entity);
        public T Update(T entity);
        public void Delete(T entity);
        public void DeleteRange(IQueryable<T> entities);
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        public int SaveChanges();


    }
}
