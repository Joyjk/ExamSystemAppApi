using ExamSystemAppApi.Models;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public interface ICandidateService
    {
        List<Candidate> GetAllQuizCandidate();
        void InsertNewCandidate(Candidate candidate);
        void UpdateCandidate(Candidate candidate);
        void DeleteCandidate(int id);
    }
}
