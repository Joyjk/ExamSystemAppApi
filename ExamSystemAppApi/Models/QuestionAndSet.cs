namespace ExamSystemAppApi.Models
{
    public class QuestionAndSet
    {
        public int QuestionAndSetId { get; set; }
        public int SetNameId { get; set; }
        public int QuestionId { get; set; }
        public int CandidateTypeId { get; set; }
        public int SessionId { get; set; }
        public string TimeDuration { get; set; }
    }
}
