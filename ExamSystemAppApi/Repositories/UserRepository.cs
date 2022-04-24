using ExamSystemAppApi.Models;

namespace ExamSystemAppApi.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(ExamSystemContext examSystemContext) : base(examSystemContext)
        {
        }
    }
}
