//using ExamSystemAppApi.EFCore;
using ExamSystemAppApi.Models;
using ExamSystemAppApi.Repository;
using ExamSystemAppApi.Repository.Interface;
using ExamSystemAppApi.Services;
using ExamSystemAppApi.Services.Others;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSystemAppApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ExamSystemAppApi", Version = "v1" });
            });
            var ConnectionString = Configuration.GetConnectionString("DefaultConnection");

            // services.AddDbContext<ExamSystemEFContext>(options=>options.UseSqlServer(ConnectionString));
            services.AddSingleton<IUserService, UserService>();
            //services.AddSingleton<ICandidateService, CandidateService>();
            //services.AddSingleton<IQuestionService, QuizQuestion>();
            services.AddTransient (typeof(IBaseService<>), typeof(BaseService<>));
            services.AddSingleton<IQuestionService, QuestionServiceDemo>();
            services.AddDbContext<ExamSystemContext>(options => options.UseSqlServer(ConnectionString));
            services.AddTransient<IAnsSheetService, AnsSheetService>();
            services.AddScoped<IRepostitoryWrapper, RepositoryWrapper>();

            services.AddCors(options => options.AddDefaultPolicy(builder => builder.AllowAnyOrigin()));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ExamSystemAppApi v1"));
            }
            
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(x => x.AllowAnyMethod()
                             .AllowAnyHeader()
                             .SetIsOriginAllowed(origin => true)
                             .AllowCredentials());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
