namespace ExamSystemAppApi.Models
{
    public class QuestionAndOptions
    {
        public int QuestionId { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public decimal? Mark { get; set; }
        public int? OptionId { get; set; }
        public string OptionUid { get; set; }
        public string WrittenAns { get; set; }
        public string CorrectAns { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }
    }
}
