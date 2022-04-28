using ExamSystemAppApi.Models;
using ExamSystemAppApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly IBaseService<Candidate> candidateService;

        public CandidatesController(IBaseService<Candidate> candidateService)
        {
            this.candidateService = candidateService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(candidateService.GetAllEntity());
        }
        [HttpPost]
        public IActionResult Post(Candidate candidate)
        {
            candidateService.InsertEntity(candidate);
            return Created("Created", candidate);
        }
        [HttpPut]
        public IActionResult Put(Candidate candidate)
        {
            candidateService.UpdateEntity(candidate);
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            candidateService.DeleteEntity(id);
            return NoContent();
        }
    }
}
