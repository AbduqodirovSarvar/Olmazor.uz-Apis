using Infrastructure.Persistance.EntityFramework;
using Microsoft.EntityFrameworkCore;
using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

var app = builder.Build();

app.ConfigurePipeline();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = services.GetRequiredService<AppDbContext>();
try
{
    await context.Database.MigrateAsync();
    Console.WriteLine("Migrations applied successfully.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error applying migrations: {ex.Message}");
}
try
{
    await context.SeedAsync();
    Console.WriteLine("default data added succesfully.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

app.Run();
