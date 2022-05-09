using ExamSystemAppApi.Models;
using FIK.DAL.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ExamSystemAppApi.Services
{
    public class AnsSheetService : IAnsSheetService
    {
        private readonly IConfiguration configuration;
        private readonly ExamSystemContext examSystemContext;
        SQL _sqlDal = null;
        string msg = "";

        public AnsSheetService(IConfiguration configuration, ExamSystemContext examSystemContext) 
        {
            this.configuration = configuration;
            this.examSystemContext = examSystemContext;
            _sqlDal = new SQL(configuration.GetConnectionString("DefaultConnection"));
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

            _sqlDal.Insert<AnsSheet>(ansSheets, "", "AnsSheetId", "AnsSheets", ref msg);
        }

        public void UpdateAnsSheet(AnsSheet ansSheet)
        {
            _sqlDal.Update<AnsSheet>(ansSheet, "", "AnsSheetId", "AnsSheets", ref msg);
        }
        public void UpdateAnsSheetEF(AnsSheet ansSheet)
        {
            //examSystemContext.Entry(ansSheet).State = EntityState.Modified;
            //var entity = examSystemContext.AnsSheets.Find(ansSheet.AnsSheetId);
            examSystemContext.AnsSheets.Update(ansSheet);

            examSystemContext.SaveChanges();
        }
    }
}
