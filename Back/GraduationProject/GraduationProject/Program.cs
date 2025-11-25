// مهم عشان AddProjectServices تشتغل (Namespace بتاعك)

namespace GraduationProject;
using GraduationProject;

public class Program
    {
    public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            //builder.Services.AddIdentityApiEndpoints<ApplicationUser>()
            //    .AddEntityFrameworkStores<AppDbContext>();


            //(Controllers + FluentValidation + Mapster + Swagger)
            builder.Services.AddProjectServices(builder.Configuration);

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();


            app.UseAuthorization();

            //app.MapIdentityApi<ApplicationUser>();

            app.MapControllers();


            app.Run();
        }
    }

