using ExamSystemAppApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ExamSystemAppApi.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ExamSystemContext examSystemContext;

        public BaseRepository(ExamSystemContext examSystemContext)
        {
            this.examSystemContext = examSystemContext;
        }
        
        public TEntity GetByID(int id)
        {
            return examSystemContext.Set<TEntity>().Find(id);
        }
        public void Delete(int id)
        {
            examSystemContext.Set<TEntity>().Remove(GetByID(id));
        }

        public void DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        
    }
}
