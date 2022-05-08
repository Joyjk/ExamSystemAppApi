using ExamSystemAppApi.Models;
using ExamSystemAppApi.Repository.Interface;
using Microsoft.Extensions.Configuration;

namespace ExamSystemAppApi.Repository
{
    public class QuestionRepository : BaseRepository<QuizQuestion>, IQuestionRepository
    {
        public QuestionRepository(IConfiguration configuration) : base(configuration)
        {

        }
        //public void InsertNew(QuizQuestion qQsn)
        //{
        //    QuizQuestion quizQuestion1 = new QuizQuestion();
        //    quizQuestion1.QuestionId = qQsn.QuestionId;
        //    quizQuestion1.QuestionType = qQsn.QuestionType;
        //    quizQuestion1.Question = qQsn.Question;
        //    quizQuestion1.Mark = qQsn.Mark;
        //    //quizQuestion1.OptionId = qQsn.OptionId;
        //    quizQuestion1.OptionUid = qQsn.OptionUid;


        //    QuizOption quizOption = new QuizOption();
        //    // quizOption.OptionId = (int)qQsn.OptionId;

        //    quizOption.OptionUid = qQsn.OptionUid;

        //    quizOption.Option1 = qQsn.Options.Option1;
        //    quizOption.Option2 = qQsn.Options.Option2;
        //    quizOption.Option3 = qQsn.Options.Option3;
        //    quizOption.Option4 = qQsn.Options.Option4;
        //    quizOption.Option5 = qQsn.Options.Option5;
        //    quizOption.CorrectAns = qQsn.Options.CorrectAns;
        //    quizOption.WrittenAns = qQsn.Options.WrittenAns;

        //    _sqlDal.Insert<QuizQuestion>(quizQuestion1, "", "QuestionId", "QuizQuestions", ref msg);

        //    _sqlDal.Insert<QuizOption>(quizOption, "", "OptionId", "QuizOptions", ref msg);



        //}

    }
}
