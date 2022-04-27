using FIK.DAL.Core;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public class BaseService<T> : IBaseService<T> where T : class ,new()
    {
        SQL _sqlDal = null;
        string msg = "";
        public BaseService(IConfiguration configuration)
        {
            _sqlDal = new SQL(configuration.GetConnectionString("DefaultConnection"));
        }
        public void DeleteEntity(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<T> GetAllEntity()
        {
            string q = string.Format(@"select * from "+typeof(T).Name+" ");
            var users = _sqlDal.Select<T>(q, ref msg);
            return users;
           
        }

        public void InsertEntity(T tentity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEntity(T tentity)
        {
            throw new System.NotImplementedException();
        }
    }

}
