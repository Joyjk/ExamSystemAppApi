using ExamSystemAppApi.Models;
using ExamSystemAppApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnsSheetsController : ControllerBase
    {
        private readonly IAnsSheetService ansSheetService;

        public AnsSheetsController(IAnsSheetService ansSheetService)
        {
            this.ansSheetService = ansSheetService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ansSheetService.GetAllQuizAnswers());
        }
        [HttpPost]
        public IActionResult Post(AnsSheet ansSheet)
        {
            ansSheetService.InsertNewAnsSheet(ansSheet);
            return Created("", ansSheet);
        }
        [HttpPut]
        public IActionResult Put(AnsSheet ansSheet)
        {
            ansSheetService.UpdateAnsSheetEF(ansSheet);
            return Ok("Updated");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            ansSheetService.DeleteAnsSheet(id);
            return NoContent();
        }
    }
}
