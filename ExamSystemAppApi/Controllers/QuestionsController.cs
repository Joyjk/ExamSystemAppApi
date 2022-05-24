using ExamSystemAppApi.Models;
using ExamSystemAppApi.Repository.Interface;
using ExamSystemAppApi.Services;
using ExamSystemAppApi.Services.Others;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        #region technique2
        //private readonly IRepostitoryWrapper repostitoryWrapper;
        //public QuestionsController(IRepostitoryWrapper repostitoryWrapper)
        //{
        //    this.repostitoryWrapper = repostitoryWrapper;
        //}

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(repostitoryWrapper.QuestionRepository.GetAllEntity());
        //}
        #endregion

       
        //private readonly QuestionService questionService;

        //private readonly QuestionService questionService;
        private readonly IQuestionService questionService;

        //private readonly IBaseService<QuizQuestion> quizQuestionService;

        //public QuestionsController(IBaseService<QuizQuestion> quizQuestionService)
        //{
        //    this.quizQuestionService = quizQuestionService;
        //}


        public QuestionsController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }
        //public QuestionsController(IQuestionService questionService)
        //{
        //    this.questionService = questionService;
        //}
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(questionService.GetAlls());
        }
        [HttpPost]
        public IActionResult Post(QuizQuestion quizQuestion)
        {
            questionService.InsertNew(quizQuestion);
            return Created("", quizQuestion);

        }
        [HttpPut]
        public IActionResult Put(QuizQuestion quizQuestion)
        {
            questionService.UpdateQuestion(quizQuestion);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            questionService.DeleteQuestion(id);
            return NoContent();
        }
       
        [HttpGet("getallquestions")]
        public IActionResult GetAllQuestions()
        {
            return Ok(questionService.GetAll());
        }

        [HttpPost("SetQuestionSets")]
        public IActionResult SetQuestionSet(QuestionSetOption questionSetOption)
        {
            questionService.InsertQuestionSet(questionSetOption);
            return Ok();
        }
        [HttpPost("AddExamType")]
        public IActionResult AddExamType(QuestionSet questionSet)
        {
            questionService.AddExamType(questionSet);
            return Created("", questionSet);
        }

        [HttpPost("AddSetName")]
        public IActionResult AddSetName(SetName setName)
        {
            questionService.InsertSetName(setName);
            return Created("",setName);
        }
        [HttpGet("GetAllSetName")]
        public IActionResult GetAllSetName()
        {
            return Ok(questionService.GetAllSetName());
        }
        [HttpPost("AddCandidateType")]
        public IActionResult AddCandidateType(CandidateType candidateType)
        {
            questionService.InsertCandidateType(candidateType);
            return Created("", candidateType);
        }
        [HttpGet("GetAllCandidateType")]
        public IActionResult GetAllCandidateType()
        {
            return Ok(questionService.GetAllCandidateType());
        }
        [HttpPost("AddCandidateSession")]
        public IActionResult AddSession(Session session)
        {
            questionService.InsertSession(session);
            return Created("", session);
        }
        [HttpGet("GetCandidateSession")]
        public IActionResult GetAllSession()
        {
            return Ok(questionService.GetAllSession());
        }
        [HttpPost("SetAndQuestionsMapping")]
        public IActionResult AddQuestionAndSet(QuestionAndSet questionAndSet)
        {
            questionService.InsertQuestionAndSet(questionAndSet);
            return Created("",questionAndSet);
        }

        [HttpGet("GetAllAssignQusBeforeExam")]
        public IActionResult GetAllAssignQusBeforeExam()
        {
            return Ok(questionService.GetAllAssignQusBeforeExam());
        }

        





    }
}
