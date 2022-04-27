using ExamSystemAppApi.Models;
using Microsoft.Extensions.Configuration;

namespace ExamSystemAppApi.Services
{
    public class AnsSheetService : BaseService<AnsSheet>
    {
        private readonly IConfiguration configuration;

        public AnsSheetService(IConfiguration configuration) : base(configuration)
        {
            this.configuration = configuration;
        }
        

    }
}
