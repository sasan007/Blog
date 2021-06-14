using BlogManagement.Core.ApplicationServices.Service;
using BlogManagement.Core.Domain.Repository;
using BlogManagement.Endpoints.API.Middleware;
using BlogManagement.Infra.Data.Sql.Context;
using BlogManagement.Infra.Data.Sql.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Serilog;

namespace BlogManagement.Endpoints.API
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BlogManagement.Endpoints.API", Version = "v1" });
            });

            services.AddDbContext<EFDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BlogManagementCnn")));
            
            services.AddScoped<BlogRepository, EfBlogRepository>();
            services.AddScoped<PostRepository, EfPostRepository>();
            services.AddScoped<CommentRepository, EfCommentRepository>();

            services.AddScoped<BlogApplicaitonService>();
            services.AddScoped<PostApplicaitonService>();
            services.AddScoped<CommentApplicaitonService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BlogManagement.Endpoints.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSerilogRequestLogging();

            app.UseMiddleware<LoggingMiddleware>();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
