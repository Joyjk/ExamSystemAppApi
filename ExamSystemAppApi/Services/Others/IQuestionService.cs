using ExamSystemAppApi.Models;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services.Others
{
    public interface IQuestionService
    {
        List<QuizQuestion> GetAll();
        List<QuestionAndOptions> GetAlls();
        void InsertNew(QuizQuestion quizQuestion);
        void UpdateQuestion(QuizQuestion quizQuestion);
        void DeleteQuestion(int id);
        
        void InsertQuestionSet(QuestionSetOption questionSetOption);
        void AddExamType(QuestionSet questionSet);
    }
}
