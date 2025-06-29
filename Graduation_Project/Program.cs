
using Graduation_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Graduation_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Get Connection String
            //builder.Services.AddDbContext<Final_ProjectContext>(options =>
            //{
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            //});
            builder.Services.AddDbContext<Final_ProjectContext>(options =>
                    options.UseSqlServer(
                    builder.Configuration.GetConnectionString("cs"),
                    x => x.UseNetTopologySuite()));
            builder.Services.AddHttpClient(); // Required for HttpClient in your controller

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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
}
