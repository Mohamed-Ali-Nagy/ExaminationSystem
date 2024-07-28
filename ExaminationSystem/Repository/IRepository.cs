namespace ExaminationSystem.Repository
{
    public interface IRepository<T>
    {
        public T GetById(int ID);
        public IQueryable<T> GetAll();

        public T Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);


    }
}
