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
            string q = string.Format(@"select * from "+typeof(T).Name+"s ");
            var data = _sqlDal.Select<T>(q, ref msg);
            return data; 
        }

        public void InsertEntity(T tentity)
        {
            var data = new List<T>();
            data.Add(tentity);

            //_sqlDal.Insert<T>(data, "", "\""+typeof(T).Name+"Id\"", "AnsSheets", ref msg);
            _sqlDal.Insert<T>(data, "", "", "AnsSheets", ref msg);
        }

        public void UpdateEntity(T tentity)
        {
            throw new System.NotImplementedException();
        }
    }

}
