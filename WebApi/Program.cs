using Microsoft.EntityFrameworkCore;
using Repositories.EFCore;
using WebApi.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);



        builder.Services.AddControllers()
            .AddApplicationPart(typeof(Presentation.AssemblyReference)
            .Assembly).AddNewtonsoftJson();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.ConfigureSqlContext(builder.Configuration);
        builder.Services.ConfigureServiceManager();


        builder.Services.ConfigureRepositoryManager();


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