using ExamSystemAppApi.Models;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public interface IQuizOptionService
    {
        List<QuizOption> GetAllQuizOption();
        void InsertNewOption(QuizOption quizOption);
        void UpdateOption(QuizOption quizOption);
        void DeleteOption(int id);
    }
}
