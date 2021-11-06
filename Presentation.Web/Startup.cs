using Bks.TrainingDevelopment.Application;
using Bks.TrainingDevelopment.Presentation.Web.Filters.Swagger;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.FeatureManagement;
using Microsoft.OpenApi.Models;

namespace Bks.TrainingDevelopment.Presentation.Web
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

            services.AddMediatR(typeof(ForMediator));

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