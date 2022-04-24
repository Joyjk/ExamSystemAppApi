using ExamSystemAppApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ExamSystemAppApi.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ExamSystemContext examSystemContext;

        public BaseRepository(ExamSystemContext examSystemContext)
        {
            this.examSystemContext = examSystemContext;
        }
        public T Delete(object id)
        {
            try
            {
                examSystemContext.Remove(GetById(id));
                examSystemContext.SaveChanges();
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public T GetById(object id)
        {
            try
            {
                return examSystemContext.Set<T>().Find(id);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        public T Insert(T entity)
        {
            try
            {
                examSystemContext.Set<T>().Add(entity);
                examSystemContext.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T Update(T entity)
        {
            
            try
            {
                examSystemContext.Entry(entity).State = EntityState.Modified;
                examSystemContext.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
