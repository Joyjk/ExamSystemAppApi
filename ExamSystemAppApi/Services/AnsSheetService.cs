using ExamSystemAppApi.Models;
using FIK.DAL.Core;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public class AnsSheetService : IAnsSheetService
    {
        private readonly IConfiguration configuration;
        SQL _sqlDal = null;
        string msg = "";

        public AnsSheetService(IConfiguration configuration) 
        {
            this.configuration = configuration;
        }

        public void DeleteAnsSheet(int id)
        {
            var query = "select * from AnsSheets where AnsSheetId=" + id;
            var ansSheet = _sqlDal.SelectFirstOrDefault<AnsSheet>(query, ref msg);
            _sqlDal.Delete<AnsSheet>(ansSheet, "AnsSheetId", "AnsSheets", ref msg);
        }

        public List<AnsSheet> GetAllQuizAnswers()
        {
            string q = string.Format(@"select * from AnsSheets");
            var ansSheets = _sqlDal.Select<AnsSheet>(q, ref msg);
            return ansSheets;
        }

        public void InsertNewAnsSheet(AnsSheet ansSheet)
        {
            var ansSheets = new List<AnsSheet>();
            ansSheets.Add(ansSheet);

            _sqlDal.Insert<QuizOption>(ansSheets, "", "AnsSheetId", "AnsSheets", ref msg);
        }

        public void UpdateAnsSheet(AnsSheet ansSheet)
        {
            _sqlDal.Update<AnsSheet>(ansSheet, "", "AnsSheetId", "AnsSheets", ref msg);
        }
    }
}
