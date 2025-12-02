using CarServiceMy.BL;
using CarServiceMy.DL;
using CarServiceMy.DL.Interfaces;
using Microsoft.OpenApi.Models;

namespace CarServiceMy.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .AddDataLayer()
                .AddBusinessLogicLayer();

            builder.Services.AddControllers();
         
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Car Service My", Version = "v1" });
            });

            var app = builder.Build();
            // Configure the HTTP request pipeline.

            //app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("v1/swagger.json", "Car Service My V1");
            });

            app.UseSwagger();

            app.Run();
        }
    }
}
