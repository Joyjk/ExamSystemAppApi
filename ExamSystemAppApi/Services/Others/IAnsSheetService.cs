using ExamSystemAppApi.Models;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public interface IAnsSheetService 
    {
        List<AnsSheet> GetAllQuizAnswers();
        void InsertNewAnsSheet(AnsSheet ansSheet);
        void UpdateAnsSheet(AnsSheet ansSheet);
        void DeleteAnsSheet(int id);
        void UpdateAnsSheetEF(AnsSheet ansSheet);
        AnsSheet GetById(int id);
    }
}
