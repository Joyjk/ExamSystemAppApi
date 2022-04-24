using Microsoft.EntityFrameworkCore;
using System;

namespace ExamSystemAppApi.Enities
{

    [Keyless]
    public class QuestionSets
    {
        public int QuestionSetId { get; set; }
        public string CandidateType { get; set; }
        public string Session { get; set; }
        public DateTime TimeDuration { get; set; }
        public int QuestionSetOptionId { get; set; }
    }
}
