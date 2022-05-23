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
        void InsertSetName(SetName setName);
        List<SetName> GetAllSetName();
        void InsertCandidateType(CandidateType candidateType);
        List<CandidateType> GetAllCandidateType();
        void InsertSession(Session session);
        List<Session> GetAllSession();
        void InsertQuestionAndSet(QuestionAndSet questionAndSet);
        List<QuestionAndSet> GetAllQuestionAndSet();
    }
}
