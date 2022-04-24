using Microsoft.EntityFrameworkCore;
using System;

namespace ExamSystemAppApi.Enities
{

    [Keyless]
    public class AnsSheets
    {
        public int AnsSheetId { get; set; }
        public int CandidateId { get; set; }
        public int QuestionId { get; set; }
        public string GivenAns { get; set; }
        public double GivenMark { get; set; }
        public DateTime SubmitedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
