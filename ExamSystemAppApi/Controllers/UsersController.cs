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
       
        private readonly IUserService userService;
        
        public UsersController(IUserService userService)
        {
            
            this.userService = userService;
           
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(userService.GetAllUsers());
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            

            userService.InsertNewUser(user);


            return Created("created", user);
        }
        [HttpPut]
        public IActionResult Put(User user)
        {
          
            userService.UpdateUser(user);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
           
            userService.DeleteUser(id);
            return NoContent();
        }


    }
}
