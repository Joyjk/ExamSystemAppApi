using ExamSystemAppApi.Models;
using FIK.DAL.Core;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly IConfiguration configuration;
        SQL _sqlDal = null;
        string msg = "";
        public CandidateService(IConfiguration configuration)
        {
            this.configuration = configuration;
            _sqlDal = new SQL(configuration.GetConnectionString("DefaultConnection"));
        }

        public void DeleteCandidate(int id)
        {
            var query = "select * from Candidates where CandidateId=" + id;
            var candidate = _sqlDal.SelectFirstOrDefault<Candidate>(query, ref msg);
            _sqlDal.Delete<Candidate>(candidate, "CandidateId", "Candidates", ref msg);
        }

        public List<Candidate> GetAllQuizCandidate()
        {
            string q = string.Format(@"select * from Candidates");
            var candidates = _sqlDal.Select<Candidate>(q, ref msg);
            return candidates;
        }

        public void InsertNewCandidate(Candidate candidate)
        {
            var candidateList = new List<Candidate>();
            candidateList.Add(candidate);

            _sqlDal.Insert<Candidate>(candidateList, "", "CandidateId", "Candidates", ref msg);
        }

        public void UpdateCandidate(Candidate candidate)
        {
            _sqlDal.Update<Candidate>(candidate, "", "CandidateId", "Candidates", ref msg);
        }
    }
}
