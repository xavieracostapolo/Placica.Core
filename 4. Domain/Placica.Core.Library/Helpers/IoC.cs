using Microsoft.Extensions.DependencyInjection;
using Placica.Core.Library.Contracts.DomainServices;
using Placica.Core.Library.DomainServices;
using Entity = Placica.Core.Library.Entities;

namespace Placica.Core.Library.Helpers
{
    public static class IoC
    {
        public static void AddDependencyDomain(this IServiceCollection services)
        {
            services.AddTransient<IDomainService<Entity.Calificacion>, CalificacionDomainService>();
            services.AddTransient<IDomainService<Entity.Categoria>, CategoriaDomainService>();
            services.AddTransient<IDomainService<Entity.Cliente>, ClienteDomainService>();
            services.AddTransient<IDomainService<Entity.Empresa>, EmpresaDomainService>();
            services.AddTransient<IDomainService<Entity.PedidoDetalle>, PedidoDetalleDomainService>();
            services.AddTransient<IDomainService<Entity.Pedido>, PedidoDomainService>();
            services.AddTransient<IDomainService<Entity.Producto>, ProductoDomainService>();
            services.AddTransient<IDomainService<Entity.Usuario>, UsuarioDomainService>();
        }
    }
}