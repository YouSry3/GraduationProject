using GraduationProject.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace GraduationProject
{
    public static class GlobalDependancyInjection
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services, IConfiguration configuration)
        {
            // DbContext
            services.AddDbContext<AppDbContext>(options =>
                // Use SQL Server                                    ============= Path Connection in appSettings.json file ==============
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            var AllowsOrigin = configuration.GetSection("AllowedOrigin").Get<string[]>();

            services.AddCors(options =>
                   options.AddPolicy("AllowAll", builder =>
                   builder
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .WithOrigins(AllowsOrigin!)
                   ));

            //Custom Allow Origin for specific client
            //.WithOrigins("http://localhost:5173")


            // Controllers + FluentValidation
            services.AddControllers();



            // Swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }

       
       
    }
}
