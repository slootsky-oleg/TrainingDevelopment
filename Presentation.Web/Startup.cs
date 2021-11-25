using Bks.Fox.Behaviors.ResourceRequirements.Application.Commands.Add;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Queries.Get;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Queries.GetAll;
using Bks.Fox.Behaviors.ResourceRequirements.Application.Services;
using Bks.Fox.Domain.Repositories;
using Bks.Fox.TrainingDevelopment.Application.Entities.Lookups;
using Bks.Fox.TrainingDevelopment.Domain.Repositories;
using Bks.Fox.TrainingDevelopment.Tasks.Application.Commands.Create;
using Bks.Fox.TrainingDevelopment.Tasks.Application.Lookups;
using Bks.Fox.TrainingDevelopment.Tasks.Application.Queries.Get;
using Bks.Fox.TrainingDevelopment.Tasks.Application.ResourceRequirements.Services;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Entities;
using Bks.Fox.TrainingDevelopment.Tasks.Domain.Repositories;
using Bks.Fox.TrainingDevelopment.Tasks.Infrastructure.Repositories;
using Bks.WebApi.Swashbuckle.FeatureGate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.FeatureManagement;
using Microsoft.OpenApi.Models;

namespace Bks.Fox.TrainingDevelopment.Tasks.Presentation.Web
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
            services.AddFeatureManagement();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Presentation.Web", Version = "v1" });
                c.DocumentFilter<FeatureGateDocumentFilter>();
                c.DescribeAllParametersInCamelCase();
            });

            services.AddScoped<CreateTaskInteractor>();
            services.AddScoped<GetTaskInteractor>();

            services.AddScoped<AddResourceRequirementInteractor<TrainingTask>>();
            services.AddScoped<GetAllResourceRequirementsInteractor<TrainingTask>>();
            services.AddScoped<GetResourceRequirementInteractor<TrainingTask>>();
            
            services.AddScoped<ITrainingEntityRepository<TrainingTask>, TaskRepository>();
            services.AddScoped<ITrainingEntityLookup<TrainingTask>, TaskLookup>();
            services.AddScoped<IResourceRequirementRuleValidator<TrainingTask>, TaskResourceRequirementRuleValidator>();
            // services.AddScoped(typeof(IGetTrainingEntityInteractor<>), typeof(GetTrainingEntityInteractor<>));
            //
            //
            //services.AddScoped<IGetTrainingEntityInteractor<AtisTask>, GetAtisTaskInteractor>();
            //services.AddScoped<IArchiveTrainingEntityInteractor<AtisTask>, ArchiveAtisTaskInteractor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Presentation.Web v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}