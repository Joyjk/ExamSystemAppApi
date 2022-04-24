using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystemAppApi.Models
{
    public partial class QuestionSet
    {
        public int QuestionSetId { get; set; }
        public string CandidateType { get; set; }
        public string Session { get; set; }
        public DateTime? TimeDuration { get; set; }
        public int? QuestionSetOptionId { get; set; }
    }
}
