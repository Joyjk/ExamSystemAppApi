//using ExamSystemAppApi.EFCore;
//using ExamSystemAppApi.Enities;
using ExamSystemAppApi.Models;
using ExamSystemAppApi.Services;
using FIK.DAL.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace ExamSystemAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ExamSystemContext examSystemContext;
        private readonly IConfiguration configuration;
        private readonly IUserServices userService;
        SQL _sqlDal = null;
        string msg = "";
        //private readonly ExamSystemEFContext examSystemEFContext;

        //public UsersController(ExamSystemEFContext examSystemEFContext)
        //{
        //    this.examSystemEFContext = examSystemEFContext;
        //}

        public UsersController(ExamSystemContext examSystemContext, IConfiguration configuration, IUserServices userService)
        {
            this.examSystemContext = examSystemContext;
            this.configuration = configuration;
            this.userService = userService;
            _sqlDal = new SQL(configuration.GetConnectionString("DefaultConnection"));
        }

        [HttpGet]
        public IActionResult Get()
        {
            ////User users = _sqlDal.Select("select * from users", ref msg);
            string q = string.Format(@"select * from users");
            var users = _sqlDal.Select<User>(q,ref msg);
            //userService.GetAllUsers();


            return Ok(userService.GetAllUsers());
            //return Ok(examSystemContext.QuizOptions.ToList()); ;
            //return Ok(examSystemEFContext.Users.ToList());
            //string query = string.Format(@"select a.admission_date, a.invoice_id from hospital.admission a where a.admission_id = '" + obj.aAdmissionServiceDetails.admission_id + "'";
           // var aAdmission = _sqlDal.SelectFirstOrDefault<Admission>(query, ref msg);

        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            //examSystemContext.Users.Add(user);
            //examSystemContext.SaveChanges();

            var userList = new List<User>();
            userList.Add(user);

            _sqlDal.Insert<User>(userList,"","Id","Users",ref msg);


            return Created("created", user);
        }
        [HttpPut]
        public IActionResult Put(User user)
        {
            //user.Id = id;
            //examSystemContext.Users.Update(user);
            //examSystemContext.SaveChanges();
            _sqlDal.Update<User>(user, "", "id", "Users", ref msg);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            //var user = examSystemContext.Users.Find(id);
            var query = "select * from Users where id=" + id;
            var user = _sqlDal.SelectFirstOrDefault<User>(query,ref msg);
            //examSystemContext.Users.Remove(user);
            //examSystemContext.SaveChanges();
            _sqlDal.Delete<User>(user, "Id", "Users", ref msg);
            return NoContent();
        }
    }
}
