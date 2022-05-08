using ExamSystemAppApi.Repository.Interface;
using FIK.DAL.Core;
using Microsoft.Extensions.Configuration;

namespace ExamSystemAppApi.Repository
{
    public class RepositoryWrapper : IRepostitoryWrapper
    {
        private readonly IConfiguration configuration;
        SQL _sqlDal = null;
        string msg = "";
        private IQuestionRepository _questionRepository;
        public RepositoryWrapper(IConfiguration configuration)
        {
            //_sqlDal = new SQL(configuration.GetConnectionString("DefaultConnection"));
            this.configuration = configuration;
        }
        public IQuestionRepository QuestionRepository
        {
            get 
            {
                _questionRepository = new QuestionRepository(configuration);//new SQL(configuration.GetConnectionString("DefaultConnection"))
                return _questionRepository;
            }
        }
    }
}
