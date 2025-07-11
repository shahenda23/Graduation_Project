using Graduation_Project.Models;
using Graduation_Project.Repository;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;

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

            // Context
            builder.Services.AddDbContext<Final_ProjectContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("GP"),
                    sqloptions =>
                    {
                        sqloptions.EnableRetryOnFailure(
                            maxRetryCount: 5,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null);
                        sqloptions.UseNetTopologySuite();
                    }).EnableSensitiveDataLogging(false).EnableDetailedErrors();
            });

            // Repository
            builder.Services.AddScoped<ICVIRepository, CVIRepository>();
            builder.Services.AddScoped<ITimeSeriesRepository, TimeSeriesRepository>();
            builder.Services.AddScoped<ISHORELINE_2023_POINTS_100M_Repository, SHORELINE_2023_POINTS_100M_Repository>();
            builder.Services.AddScoped<ISHORELINE_2023_SEGMENTED_PROJECT_Repository, SHORELINE_2023_SEGMENTED_PROJECT_Repository>();

            // React
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("ReactPolicy", policy =>
                {
                    policy.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod();
                });
            });
            
            // NetTopologySuite
            builder.Services.AddSingleton<NetTopologySuite.IO.WKTReader>(_ => 
                new NetTopologySuite.IO.WKTReader(NtsGeometryServices.Instance.CreateGeometryFactory()));
            
            // Controller
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

            app.UseCors("ReactPolicy");                                                                                                                                                                                                                                                                                                                                                                                                                                                              

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