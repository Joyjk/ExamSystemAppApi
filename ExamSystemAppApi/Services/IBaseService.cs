using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public interface IBaseService<T> where T : class
    {
        List<T> GetAllEntity();
        void InsertEntity(T tentity);
        void UpdateEntity(T tentity);
        void DeleteEntity(int id);
    }
}
