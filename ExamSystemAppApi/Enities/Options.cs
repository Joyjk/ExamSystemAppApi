using Microsoft.EntityFrameworkCore;

namespace ExamSystemAppApi.Enities
{
    [Keyless]
    public class Options
    {
        public int OptionId { get; set; }
        public string WrittenAns { get; set; }
        public string CorrectAns { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }
    }
}
