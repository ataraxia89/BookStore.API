using BookStore.API.Data;
using BookStore.API.Data.Repositories;
using BookStore.API.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var configBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        var configuration = configBuilder.Build();

        builder.Services.AddDbContext<BookStoreDbContext>(option =>
            option.UseSqlite(configuration.GetConnectionString("SQLConnection")));

        builder.Services.AddScoped<IBooksRepository, BooksRepository>();

        builder.Services.AddRouting(options => options.LowercaseUrls = true);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

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