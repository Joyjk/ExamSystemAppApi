using Microsoft.EntityFrameworkCore;

namespace ExamSystemAppApi.Enities
{

    [Keyless]
    public class QuestionSetOptions
    {
        public int QuestionSetOptionId { get; set; }
        public int SetId { get; set; }
        public int QuestionId { get; set; }
    }
}
