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

namespace Placica.Core.WebAPI.Helpers
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<IService<Model.Calificacion>, CalificacionService>();
            services.AddTransient<IApplicationService<Dto.Calificacion>, CalificacionApplicationService>();
            services.AddTransient<IDomainService<Entity.Calificacion>, CalificacionDomainService>();
            services.AddScoped<IRepository<Entity.Calificacion>, CalificacionRepository>();

            services.AddTransient<IService<Model.Categoria>, CategoriaService>();
            services.AddTransient<IApplicationService<Dto.Categoria>, CategoriaApplicationService>();
            services.AddTransient<IDomainService<Entity.Categoria>, CategoriaDomainService>();
            services.AddScoped<IRepository<Entity.Categoria>, CategoriaRepository>();

            services.AddTransient<IService<Model.Cliente>, ClienteService>();
            services.AddTransient<IApplicationService<Dto.Cliente>, ClienteApplicationService>();
            services.AddTransient<IDomainService<Entity.Cliente>, ClienteDomainService>();
            services.AddScoped<IRepository<Entity.Cliente>, ClienteRepository>();

            services.AddTransient<IService<Model.Empresa>, EmpresaService>();
            services.AddTransient<IApplicationService<Dto.Empresa>, EmpresaApplicationService>();
            services.AddTransient<IDomainService<Entity.Empresa>, EmpresaDomainService>();
            services.AddScoped<IRepository<Entity.Empresa>, EmpresaRepository>();

            services.AddTransient<IService<Model.PedidoDetalle>, PedidoDetalleService>();
            services.AddTransient<IApplicationService<Dto.PedidoDetalle>, PedidoDetalleApplicationService>();
            services.AddTransient<IDomainService<Entity.PedidoDetalle>, PedidoDetalleDomainService>();
            services.AddScoped<IRepository<Entity.PedidoDetalle>, PedidoDetalleRepository>();

            services.AddTransient<IService<Model.Pedido>, PedidoService>();
            services.AddTransient<IApplicationService<Dto.Pedido>, PedidoApplicationService>();
            services.AddTransient<IDomainService<Entity.Pedido>, PedidoDomainService>();
            services.AddScoped<IRepository<Entity.Pedido>, PedidoRepository>();

            services.AddTransient<IService<Model.Producto>, ProductoService>();
            services.AddTransient<IApplicationService<Dto.Producto>, ProductoApplicationService>();
            services.AddTransient<IDomainService<Entity.Producto>, ProductoDomainService>();
            services.AddScoped<IRepository<Entity.Producto>, ProductoRepository>();

            return services;
        }
    }
}