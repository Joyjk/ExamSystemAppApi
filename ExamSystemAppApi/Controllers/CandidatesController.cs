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
        private readonly ICandidateService candidateService;

        public CandidatesController(ICandidateService candidateService)
        {
            this.candidateService = candidateService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(candidateService.GetAllQuizCandidate());
        }
        [HttpPost]
        public IActionResult Post(Candidate candidate)
        {
            candidateService.InsertNewCandidate(candidate);
            return Created("Created", candidate);
        }
        [HttpPut]
        public IActionResult Put(Candidate candidate)
        {
            candidateService.UpdateCandidate(candidate);
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            candidateService.DeleteCandidate(id);
            return NoContent();
        }
    }
}
