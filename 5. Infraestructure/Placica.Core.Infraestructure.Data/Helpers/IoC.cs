using Microsoft.Extensions.DependencyInjection;
using Placica.Core.Infraestructure.Data.Repository;
using Placica.Core.Library.Contracts.Repository;
using Entity = Placica.Core.Library.Entities;

namespace Placica.Core.Infraestructure.Data.Helpers
{
    public static class IoC
    {
        public static void AddDependencyInfraestructure(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Entity.Calificacion>, CalificacionRepository>();
            services.AddScoped<IRepository<Entity.Categoria>, CategoriaRepository>();
            services.AddScoped<IRepository<Entity.Cliente>, ClienteRepository>();
            services.AddScoped<IRepository<Entity.Empresa>, EmpresaRepository>();
            services.AddScoped<IRepository<Entity.PedidoDetalle>, PedidoDetalleRepository>();
            services.AddScoped<IRepository<Entity.Pedido>, PedidoRepository>();
            services.AddScoped<IRepository<Entity.Producto>, ProductoRepository>();
        }
    }
}