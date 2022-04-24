using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystemAppApi.Models
{
    public partial class AnsSheet
    {
        public int AnsSheetId { get; set; }
        public int CandidateId { get; set; }
        public int QuestionId { get; set; }
        public string GivenAns { get; set; }
        public decimal? GivenMark { get; set; }
        public DateTime? SubmitedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
