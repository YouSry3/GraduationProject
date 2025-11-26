
namespace GraduationProject;
using GraduationProject;

public class Program
    {
    public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);




            //(Controllers + FluentValidation  Swagger)
            builder.Services.AddProjectServices(builder.Configuration);

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();


            app.UseAuthorization();

            

            app.MapControllers();


            app.Run();
        }
    }

