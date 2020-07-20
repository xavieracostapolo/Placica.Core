using System;
using Audit.Core;
using Audit.EntityFramework.Providers;
using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Placica.Core.Impl.ServiceLibrary.Helpers;
using Placica.Core.Infraestructure.Data.Context;
using Placica.Core.Infraestructure.Data.Helpers;
using Placica.Core.Library.Helpers;
using Placica.Core.WebAPI.Helpers;
using Serilog;

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
            Log.Information("Arrancando la aplicacion.");

            Log.Information("Configurando conexion a la base de datos.");
            services.AddDbContext<PlacicaContext>(opt =>
                // opt.UseInMemoryDatabase("PlacicaDataBaseMemory")
                //opt.UseSqlite(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Placica.Core.WebAPI"))
                opt.UseMySQL(Configuration.GetConnectionString("DefaultConnection"), b =>
                    b.MigrationsAssembly("Placica.Core.WebAPI")
                )
            );

            Log.Information("Configurando Swagger.");
            services.AddSwaggerGen(c =>
            {
                c.ConfigureCustomSwaggerOptions();
            });

            Log.Information("Configurando Auditoria.");
            // Store audits as strings.
            Audit.Core.Configuration.DataProvider = new EntityFrameworkDataProvider()
            {
                AuditEntityAction = (evt, entry, auditEntity) =>
                {
                    var a = (dynamic)auditEntity;
                    a.AuditDate = DateTime.UtcNow;
                    a.UserName = evt.Environment.UserName;
                    a.AuditAction = entry.Action; // Insert, Update, Delete
                    return true; // return false to ignore the audit
                }
            };

            Audit.Core.Configuration.Setup()
                .UseRedis(redis => redis
                    .ConnectionString("localhost:6379,allowAdmin=true")
                    .AsString(str => str
                        .Key(ev => $"{ev.EventType}:{Guid.NewGuid()}")
                    )
                );

            Log.Information("Configurando IoC.");
            services.AddDependencyDistribution();
            services.AddDependencyApplication();
            services.AddDependencyDomain();
            services.AddDependencyInfraestructure();

            Log.Information("Configurando Automapper.");
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            Log.Information("Configurando Cors.");
            services.ConfigureCors();

            Log.Information("Configurando Token Autenticación.");
            services.AddTokenAuthentication(Configuration);

            Log.Information("Configurando FluentValidation.");
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

            Audit.Core.Configuration.AddCustomAction(ActionType.OnScopeCreated, scope =>
            {
                scope.Event.Environment.UserName = "xavier.acosta";
            });
        }
    }
}
