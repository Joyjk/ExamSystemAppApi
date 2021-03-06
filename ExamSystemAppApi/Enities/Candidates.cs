using Microsoft.EntityFrameworkCore;
using System;

namespace ExamSystemAppApi.Enities
{

    [Keyless]
    public class Candidates
    {
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string NumberOfPersonInFamily { get; set; }
        public DateTime Birthdate { get; set; }
        public int SscPassingYear { get; set; }
        public int HscPassingYear { get; set; }
        public int UniversityPassingYear { get; set; }
        public bool WorkExperience { get; set; }
        public string CompanyName { get; set; }
        public string ExperienceDetails { get; set; }
        public int ExperienceYear { get; set; }
        public int NidNo { get; set; }
        public int BirthCertificateNo { get; set; }
        public decimal Mark { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Password { get; set; }
    }
}
