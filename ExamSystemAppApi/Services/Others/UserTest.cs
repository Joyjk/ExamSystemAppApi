using ExamSystemAppApi.Models;
using Microsoft.Extensions.Configuration;

namespace ExamSystemAppApi.Services
{
    public class UserTest : BaseService<User>
    {
        private readonly IConfiguration configuration;

        public UserTest(IConfiguration configuration) : base(configuration)
        {
            this.configuration = configuration;
        }
    }
}
