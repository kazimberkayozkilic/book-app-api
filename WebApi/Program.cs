using Microsoft.EntityFrameworkCore;
using NLog;
using Repositories.EFCore;
using Services.Contracts;
using WebApi.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));


        builder.Services.AddControllers()
            .AddApplicationPart(typeof(Presentation.AssemblyReference)
            .Assembly).AddNewtonsoftJson();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.ConfigureSqlContext(builder.Configuration);
        builder.Services.ConfigureServiceManager();
        builder.Services.ConfigureLoggerService();
        builder.Services.ConfigureRepositoryManager();
        builder.Services.AddAutoMapper(typeof(Program));


        var app = builder.Build();

        var logger = app.Services.GetRequiredService<ILoggerService>();
        app.ConfigureExceptionHandler(logger);

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        if (app.Environment.IsProduction())
        {
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}