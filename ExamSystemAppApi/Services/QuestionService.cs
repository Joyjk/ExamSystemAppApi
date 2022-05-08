using ExamSystemAppApi.Models;
using Microsoft.Extensions.Configuration;

namespace ExamSystemAppApi.Services
{
    public class QuestionService : BaseService<QuizQuestion>
    {
        private readonly IConfiguration configuration;

        public QuestionService(IConfiguration configuration) : base(configuration)
        {
            this.configuration = configuration;
        }

    }
}
