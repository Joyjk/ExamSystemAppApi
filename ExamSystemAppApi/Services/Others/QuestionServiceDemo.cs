using ExamSystemAppApi.Models;
using ExamSystemAppApi.Models.DTOs;
using FIK.DAL.Core;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services.Others
{
    public class QuestionServiceDemo : IQuestionService
    {
        private readonly IConfiguration configuration;
        SQL _sqlDal = null;
        string msg = "";
        public QuestionServiceDemo(IConfiguration configuration)
        {
            this.configuration = configuration;
            _sqlDal = new SQL(configuration.GetConnectionString("DefaultConnection"));
        }
        public void DeleteQuestion(int id)
        {
            string uid = null;
            string sql = "Select * from QuizQuestions where QuestionId=" + id;
            var entity = _sqlDal.SelectFirstOrDefault<QuizQuestion>(sql,ref msg);
            if (entity != null)
            {
                uid = entity.OptionUid;
                string sql2 = "Select * from QuizOptions where OptionUid='" + uid+"'";
                var entity2 = _sqlDal.SelectFirstOrDefault<QuizOption>(sql2, ref msg);
                _sqlDal.Delete<QuizQuestion>(entity, "QuestionId", "QuizQuestions",ref msg);
                _sqlDal.Delete<QuizOption>(entity2, "OptionUid", "QuizOptions", ref msg);
            }

        }

        public List<QuizQuestion> GetAll()
        {
            string q = string.Format(@"select * from QuizQuestions");
            var quizQuestions = _sqlDal.Select<QuizQuestion>(q, ref msg);
            //var quizOptions = _sqlDal.Select<QuizOption>(q, ref msg);
            
            return quizQuestions;
        }
        public List<QuestionAndOptions> GetAlls()
        {
            string q = string.Format(@"select * from QuizQuestions, QuizOptions where QuizQuestions.OptionUid = QuizOptions.OptionUid");
            //var quizQuestions = _sqlDal.Select<QuizQuestion>(q, ref msg);
            var quizOptions = _sqlDal.Select<QuestionAndOptions>(q, ref msg);
            return quizOptions;
        }

        public void InsertNew(QuizQuestion qQsn)
        {
            QuizQuestion quizQuestion1 = new QuizQuestion();
            quizQuestion1.QuestionId = qQsn.QuestionId;
            quizQuestion1.QuestionType = qQsn.QuestionType;
            quizQuestion1.Question = qQsn.Question;
            quizQuestion1.Mark = qQsn.Mark;
            //quizQuestion1.OptionId = qQsn.OptionId;
            quizQuestion1.OptionUid = qQsn.OptionUid;


            QuizOption quizOption = new QuizOption();
           // quizOption.OptionId = (int)qQsn.OptionId;

            quizOption.OptionUid = qQsn.OptionUid;

            quizOption.Option1 = qQsn.Options.Option1;
            quizOption.Option2 = qQsn.Options.Option2;
            quizOption.Option3 = qQsn.Options.Option3;
            quizOption.Option4 = qQsn.Options.Option4;
            quizOption.Option5 = qQsn.Options.Option5;
            quizOption.CorrectAns = qQsn.Options.CorrectAns;
            quizOption.WrittenAns = qQsn.Options.WrittenAns;

            _sqlDal.Insert<QuizQuestion>(quizQuestion1, "", "QuestionId", "QuizQuestions", ref msg);

            _sqlDal.Insert<QuizOption>(quizOption, "", "OptionId", "QuizOptions", ref msg);

            
            
        }

        public void UpdateQuestion(QuizQuestion qQsn)
        {
            QuizQuestion quizQuestion1 = new QuizQuestion();
            quizQuestion1.QuestionId = qQsn.QuestionId;
            quizQuestion1.QuestionType = qQsn.QuestionType;
            quizQuestion1.Question = qQsn.Question;
            quizQuestion1.Mark = qQsn.Mark;
            //quizQuestion1.OptionId = qQsn.OptionId;
            quizQuestion1.OptionUid = qQsn.OptionUid;

            string sql = "select * from QuizOptions where OptionId=" + qQsn.QuestionId;
            var data = _sqlDal.SelectFirstOrDefault<QuizOption>(sql, ref msg);
            


            QuizOption quizOption = new QuizOption();
            // quizOption.OptionId = (int)qQsn.OptionId;

            //quizOption.OptionUid = qQsn.OptionUid;

            //quizOption.OptionUid = data.OptionUid;

            quizOption.Option1 = qQsn.Options.Option1;
            quizOption.Option2 = qQsn.Options.Option2;
            quizOption.Option3 = qQsn.Options.Option3;
            quizOption.Option4 = qQsn.Options.Option4;
            quizOption.Option5 = qQsn.Options.Option5;
            quizOption.CorrectAns = qQsn.Options.CorrectAns;
            quizOption.WrittenAns = qQsn.Options.WrittenAns;

            _sqlDal.Update<QuizQuestion>(quizQuestion1, "", "QuestionId", "QuizQuestions", ref msg);

            _sqlDal.Update<QuizOption>(quizOption, "", "OptionId", "QuizOptions", ref msg);


        }

        public void InsertQuestionSet(QuestionSetOption questionSetOption)
        {
            _sqlDal.Insert<QuestionSetOption>(questionSetOption, "", "QuestionSetOptionId", "QuestionSetOptions",ref msg);
        }

        public void AddExamType(QuestionSet questionSet)
        {
            _sqlDal.Insert<QuestionSet>(questionSet, "", "QuestionSetId", "QuestionSets", ref msg);
        }


        ////23/05/2022


        public void InsertSetName(SetName setName)
        {
            _sqlDal.Insert<SetName>(setName, "", "SetNameId", "SetNames", ref msg);
        }
        public List<SetName> GetAllSetName()
        {
            string sql = string.Format(@"Select * from SetNames");
            var data = _sqlDal.Select<SetName>(sql,ref msg);
            return data;
        }
        public void InsertCandidateType(CandidateType candidateType)
        {
            _sqlDal.Insert<CandidateType>(candidateType, "", "TypeId", "CandidateTypes", ref msg);

        }
        public List<CandidateType> GetAllCandidateType()
        {
            string sql = string.Format(@"Select * from CandidateTypes");
            var data = _sqlDal.Select<CandidateType>(sql,ref msg);
            return data;
        }
        public void InsertSession(Session session)
        {
            _sqlDal.Insert<Session>(session, "", "SessionId", "Sessions", ref msg);
        }
        public List<Session> GetAllSession()
        {
            string sql = string.Format(@"Select * from Sessions");
            var data = _sqlDal.Select<Session>(sql,ref msg);
            return data;
        }
        public void InsertQuestionAndSet(QuestionAndSet questionAndSet)
        {
            _sqlDal.Insert<QuestionAndSet>(questionAndSet, "", "QuestionAndSetId", "QuestionAndSets", ref msg);
        }
        public List<QuestionAndSet> GetAllQuestionAndSet()
        {
            string sql = string.Format(@"Select * from QuestionAndSets");
            var data = _sqlDal.Select<QuestionAndSet>(sql,ref msg);
            return data;
        }

        public List<AssignQusBeforeExam> GetAllAssignQusBeforeExam()
        {
            string sql = string.Format(@"select QuestionAndSets.QuestionAndSetId, QuestionAndSets.SetNameId,  SetNames.SetString, QuestionAndSets.QuestionId, QuizQuestions.Question,
                QuestionAndSets.CandidateTypeId, CandidateTypes.Designation, QuestionAndSets.SessionId, Sessions.SessionString, 
                QuestionAndSets.TimeDuration

                from QuestionAndSets, SetNames, QuizQuestions, CandidateTypes, Sessions
                where QuestionAndSets.SetNameId=SetNames.SetNameId and QuestionAndSets.QuestionId=QuizQuestions.QuestionId
                and CandidateTypes.TypeId = QuestionAndSets.CandidateTypeId 
                and Sessions.SessionId=QuestionAndSets.SessionId");
            var data = _sqlDal.Select<AssignQusBeforeExam>(sql,ref msg);
            return data;
        }





    }
}
