namespace ExaminationSystem.Repository
{
    public interface IRepository<T>
    {
        public T GetById(int ID,string include=null);
        public IQueryable<T> GetAll();

        public T Add(T entity);
        public T Update(T entity);
        public void Delete(T entity);
        public int SaveChanges();


    }
}
