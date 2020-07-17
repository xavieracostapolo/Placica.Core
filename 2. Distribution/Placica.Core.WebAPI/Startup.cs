using System;
using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Placica.Core.Impl.ServiceLibrary.Helpers;
using Placica.Core.Infraestructure.Data.Context;
using Placica.Core.Infraestructure.Data.Helpers;
using Placica.Core.Library.Helpers;
using Placica.Core.WebAPI.Helpers;

namespace Placica.Core.WebAPI
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
            services.AddDbContext<PlacicaContext>(opt =>
                // opt.UseInMemoryDatabase("PlacicaDataBaseMemory")
                //opt.UseSqlite(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Placica.Core.WebAPI"))
                opt.UseMySQL(Configuration.GetConnectionString("DefaultConnection"), b => 
                    b.MigrationsAssembly("Placica.Core.WebAPI")
                )
            );

            services.AddSwaggerGen(c =>
            {
                c.ConfigureCustomSwaggerOptions();
            });

            services.AddDependencyDistribution();
            services.AddDependencyApplication();
            services.AddDependencyDomain();
            services.AddDependencyInfraestructure();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.ConfigureCors();
            services.AddTokenAuthentication(Configuration);
            services.AddControllers()
            .AddFluentValidation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Placica Api V1");
            });

            app.ConfigureCustomExceptionMiddleware();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
