using ExamSystemAppApi.Models;
using FIK.DAL.Core;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public class UserService: IUserServices
    {
        private readonly IConfiguration configuration;
        SQL _sqlDal = null;
        string msg = "";
        public UserService(IConfiguration configuration)
        {
            this.configuration = configuration;
            _sqlDal = new SQL(configuration.GetConnectionString("DefaultConnection"));
        }
        public List<User> GetAllUsers()
        {
            string q = string.Format(@"select * from users");
            var users = _sqlDal.Select<User>(q, ref msg);
            return users;
        }

        public void InsertNewUser(User user)
        {
            var userList = new List<User>();
            userList.Add(user);

            _sqlDal.Insert<User>(userList, "", "Id", "Users", ref msg);
        }
        public void UpdateUser(User user)
        {
            _sqlDal.Update<User>(user, "", "id", "Users", ref msg);
        }
        public void DeleteUser(int id)
        {
            var query = "select * from Users where id=" + id;
            var user = _sqlDal.SelectFirstOrDefault<User>(query, ref msg);
            _sqlDal.Delete<User>(user, "Id", "Users", ref msg);
        }

        
    }
}
