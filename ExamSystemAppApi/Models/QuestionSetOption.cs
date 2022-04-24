using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystemAppApi.Models
{
    public partial class QuestionSetOption
    {
        public int QuestionSetOptionId { get; set; }
        public int SetId { get; set; }
        public int QuestionId { get; set; }
    }
}
