using GraduationProject.Persistence;
using GraduationProject.Services.Authentication;
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
                // Use Your Name Server OF (SQL Server)              ============= Path Connection in appSettings.json file ============
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Controllers + FluentValidation
            services.AddControllers();

            // Add Application Services
            services.AddServices();


            // Swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }



    }
}
