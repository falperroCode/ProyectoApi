
using BiblioDAM.Data.Models;
using BiblioDAM.services;
using BiblioDAM.services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;

namespace BiblioDAM.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<BibliotecaDamContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MiConexion")));
            //inyeccion dependecias
            builder.Services.AddScoped<IServiceLibro, ServiceLibro>();
            builder.Services.AddScoped<IServiceAutores, ServiceAutores>();
          


            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            }); ;
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
