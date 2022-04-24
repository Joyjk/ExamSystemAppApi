//using ExamSystemAppApi.EFCore;
//using ExamSystemAppApi.Enities;
using ExamSystemAppApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExamSystemAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ExamSystemContext examSystemContext;

        //private readonly ExamSystemEFContext examSystemEFContext;

        //public UsersController(ExamSystemEFContext examSystemEFContext)
        //{
        //    this.examSystemEFContext = examSystemEFContext;
        //}

        public UsersController(ExamSystemContext examSystemContext)
        {
            this.examSystemContext = examSystemContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(examSystemContext.QuizOptions.ToList()); ;
            //return Ok(examSystemEFContext.Users.ToList());
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            examSystemContext.Users.Add(user);
            examSystemContext.SaveChanges();
            return Created("created", user);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, User user)
        {
            user.Id = id;
            examSystemContext.Users.Update(user);
            examSystemContext.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var user = examSystemContext.Users.Find(id);
            examSystemContext.Users.Remove(user);
            examSystemContext.SaveChanges();
            return NoContent();
        }
    }
}
