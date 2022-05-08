using ExamSystemAppApi.Repository.Interface;
using FIK.DAL.Core;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ExamSystemAppApi.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        SQL _sqlDal = null;
        string msg = "";
        string entityId = string.Concat(typeof(T).Name + "Id");
        string entitys = string.Concat(typeof(T).Name, "s");
        public BaseRepository(IConfiguration configuration)
        {
            _sqlDal = new SQL(configuration.GetConnectionString("DefaultConnection"));
        }
        public void DeleteEntity(int id)
        {
            ///var query = "select * from Users where id=" + id;
            var item = GetById(id);
            _sqlDal.Delete<T>(item, entityId, entitys, ref msg);
        }

        public List<T> GetAllEntity()
        {
            string q = string.Format(@"select * from " + typeof(T).Name + "s ");
            var data = _sqlDal.Select<T>(q, ref msg);
            return data;
        }

        public T GetById(int id)
        {
            string query = string.Concat("select * from ", entitys, " where ", entityId, " = ", id);
            var enity = _sqlDal.SelectFirstOrDefault<T>(query, ref msg);
            return enity;
        }

        public void InsertEntity(T tentity)
        {
            var data = new List<T>();
            data.Add(tentity);

            ///string entityId = string.Concat(typeof(T).Name + "Id");
            ///string entitys = string.Concat(typeof(T).Name, "s");

            _sqlDal.Insert<T>(data, "", entityId, entitys, ref msg);
        }

        public void UpdateEntity(T tentity)
        {
            _sqlDal.Update<T>(tentity, "", entityId, entitys, ref msg);
        }
    }
}
