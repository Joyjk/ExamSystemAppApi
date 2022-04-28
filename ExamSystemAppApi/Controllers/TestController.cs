using ExamSystemAppApi.Models;
using ExamSystemAppApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExamSystemAppApi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class TestController : ControllerBase
    {
        private readonly IBaseService<User> baseService;

        public TestController(IBaseService<User> baseService)
        {
            this.baseService = baseService;
        }
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(baseService.GetAllEntity().ToList());
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            baseService.InsertEntity(user);
            return Created("created",user);
        }
        [HttpPut]
        public IActionResult Put(User user)
        {
            baseService.UpdateEntity(user);
            return Ok();
        }
        //[HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            baseService.DeleteEntity(id);
            return NoContent();
        }
    }
}
