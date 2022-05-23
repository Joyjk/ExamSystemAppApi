using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystemAppApi.Models
{
    public partial class QuizQuestion
    {
        public int QuestionId { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public decimal? Mark { get; set; }
        public int? OptionId { get; set; }
        public string OptionUid { get; set; }
        public String QuestionPicture { get; set; }
        public QuizOption Options { get; set; }
    }
}
