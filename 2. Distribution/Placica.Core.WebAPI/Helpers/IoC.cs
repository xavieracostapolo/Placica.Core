using Microsoft.Extensions.DependencyInjection;
using Placica.Core.WebAPI.Services.Contracts;
using Placica.Core.WebAPI.Services.Implementacion;
using Placica.Core.Library.Contracts.Repository;
using Placica.Core.Infraestructure.Data.Repository;
using Placica.Core.Library.Contracts.DomainServices;
using Placica.Core.Library.DomainServices;
using Placica.Core.Contracts.ServiceLibrary.Contracts;
using Placica.Core.Impl.ServiceLibrary.ApplicationServices;
using Model = Placica.Core.WebAPI.Models;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using Entity = Placica.Core.Library.Entities;
using Placica.Core.Infraestructure.Data.Context;

namespace Placica.Core.WebAPI.Helpers
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<IService<Model.Producto>, ProductoService>();
            services.AddTransient<IApplicationService<Dto.Producto>, ProductoApplicationService>();
            services.AddTransient<IDomainService<Entity.Producto>, ProductoDomainService>();
            services.AddScoped<IRepository<Entity.Producto>, ProductoRepository>();

            return services;
        }
    }
}