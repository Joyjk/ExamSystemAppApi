using ExamSystemAppApi.Models;
using FIK.DAL.Core;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public class QuizOptionService : IQuizOptionService
    {
        private readonly IConfiguration configuration;
        SQL _sqlDal = null;
        string msg = "";
        public QuizOptionService(IConfiguration configuration)
        {
            this.configuration = configuration;
            _sqlDal = new SQL(configuration.GetConnectionString("DefaultConnection"));
        }
        public void DeleteOption(int id)
        {
            var query = "select * from QuizOptions where OptionId=" + id;
            var quizOption = _sqlDal.SelectFirstOrDefault<QuizOption>(query, ref msg);
            _sqlDal.Delete<QuizOption>(quizOption, "OptionId", "QuizOptions", ref msg);
        }


        public List<QuizOption> GetAllQuizOption()
        {
            string q = string.Format(@"select * from QuizOptions");
            var quizOptions = _sqlDal.Select<QuizOption>(q, ref msg);
            return quizOptions;
        }

        public void InsertNewOption(QuizOption quizOption)
        {
            var quizOptions = new List<QuizOption>();
            quizOptions.Add(quizOption);

            _sqlDal.Insert<QuizOption>(quizOptions, "", "OptionId", "QuizOptions", ref msg);
        }

        public void UpdateOption(QuizOption quizOption)
        {
            _sqlDal.Update<QuizOption>(quizOption, "", "OptionId", "QuizOptions", ref msg);
        }
    }
}
