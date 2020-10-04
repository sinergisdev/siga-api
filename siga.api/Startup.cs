using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using siga.domain.Services;
using siga.infrastructure.Context;
using siga.infrastructure.Repository;

namespace siga.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAutoMapper();
            // Register the Swagger generator, defining 1 or more Swagger documents
            AddSwagger(services);


            //add config database context
            services.AddDbContext<SigaDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("TestConnection")));


            services.AddScoped(typeof(IGenericRepository<>), typeof(Repository<>));

            services.AddTransient<IUsuarioService, UsuarioService>();

            services.AddCors();
    
             
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"SIGA {groupName}",
                    Version = groupName,
                    Description = "SIGA API Project",
                    Contact = new OpenApiContact
                    {
                        Name = "Antofagasta Minerals",
                        Email = string.Empty,
                        Url = new Uri("https://www.aminerals.cl/"),
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SIGA Api - v1");
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

   
    }
}
