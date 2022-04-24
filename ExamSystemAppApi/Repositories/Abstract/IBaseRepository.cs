namespace ExamSystemAppApi.Repositories
{
    public interface IBaseRepository<T>
    {
        T GetById(object id);
        T Insert(T entity);
        T Update(T entity);
        T Delete(object id);
    }
}
