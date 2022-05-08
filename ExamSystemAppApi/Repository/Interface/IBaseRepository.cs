using System.Collections.Generic;

namespace ExamSystemAppApi.Repository.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAllEntity();
        void InsertEntity(T tentity);
        void UpdateEntity(T tentity);
        void DeleteEntity(int id);
        T GetById(int id);
    }
}
