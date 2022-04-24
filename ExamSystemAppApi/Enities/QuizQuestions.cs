using Microsoft.EntityFrameworkCore;

namespace ExamSystemAppApi.Enities
{
    [Keyless]
    public class QuizQuestions
    {
        public int QuestionId { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public double Mark { get; set; }
        public int OptionId { get; set; }
    }
}
