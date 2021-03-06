using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystemAppApi.Models
{
    public partial class Candidate
    {
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string NumberOfPersonInFamily { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? SscPassingYear { get; set; }
        public int? HscPassingYear { get; set; }
        public int? UniversityPassingYear { get; set; }
        public bool WorkExperience { get; set; }
        public string CompanyName { get; set; }
        public string ExperieceDetails { get; set; }
        public int? ExperienceYear { get; set; }
        public string NidNo { get; set; }
        public string BirthCertificateNo { get; set; }
        public decimal? Mark { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Password { get; set; }
        public int? QuestionSetOptionId { get; set; }
        public int? CandidateType { get; set; }
        public int? QuestionAndSetId { get; set; }
    }
}
