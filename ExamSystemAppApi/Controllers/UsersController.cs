using ExamSystemAppApi.Models;
using ExamSystemAppApi.Services;
using ExamSystemAppApi.Services.Others;
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
       


        private readonly IBaseService<User> userService;

        public UsersController(IBaseService<User> userService)
        {
            this.userService = userService;
        }



        [HttpGet]
        public IActionResult Get()
        {

            return Ok(userService.GetAllEntity());
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            userService.InsertEntity(user);

            return Created("created", user);
        }
        [HttpPut]
        public IActionResult Put(User user)
        {

            userService.UpdateEntity(user);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {

            userService.DeleteEntity(id);
            return NoContent();
        }


    }
}
