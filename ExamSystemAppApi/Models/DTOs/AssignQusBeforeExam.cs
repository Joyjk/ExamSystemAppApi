namespace ExamSystemAppApi.Models.DTOs
{
    public class AssignQusBeforeExam
    {
        public int QuestionAndSetId { get; set; }
        public int SetNameId { get; set; }
        public string SetString { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int CandidateTypeId { get; set; }
        public string Designation { get; set; }
        public int SessionId { get; set; }
        public string SessionString { get; set; }
        public string TimeDuration { get; set; }
    }
}
