using System.Collections.Generic;

namespace ExamSystemAppApi.Repositories
{
    interface IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void DeleteUser(string id);
        void Delete(int id);
        TEntity GetByID(int id);
        
    }
}
