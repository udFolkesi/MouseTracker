
using Microsoft.EntityFrameworkCore;
using MouseTracker.Application.Services;
using MouseTracker.Application.Services.Abstractions;
using MouseTracker.Infrastructure.Data;
using MouseTracker.Infrastructure.Repositories.Abstractions;
using MouseTracker.Infrastructure.Repositories;
using MouseTracker.Domain.Entities;

namespace MouseTrackerAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<MouseTrackerDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDirectoryBrowser();
            
            builder.Services.AddScoped<IBaseRepository<MouseTrack>, MouseTrackRepository>();
            builder.Services.AddScoped<IMouseTrackService, MouseTrackService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseAuthorization();

            app.MapControllers();

            app.MapGet("/", (HttpContext context) =>
            {
                context.Response.Redirect("/index.html");
            });

            app.Run();
        }
    }
}
