using Microsoft.Extensions.DependencyInjection;
using Placica.Core.Contracts.ServiceLibrary.Contracts;
using Placica.Core.Impl.ServiceLibrary.ApplicationServices;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;

namespace Placica.Core.Impl.ServiceLibrary.Helpers
{
    public static class IoC
    {
        public static void AddDependencyApplication(this IServiceCollection services)
        {
            services.AddTransient<IApplicationService<Dto.Calificacion>, CalificacionApplicationService>();
            services.AddTransient<IApplicationService<Dto.Categoria>, CategoriaApplicationService>();
            services.AddTransient<IApplicationService<Dto.Cliente>, ClienteApplicationService>();
            services.AddTransient<IApplicationService<Dto.Empresa>, EmpresaApplicationService>();
            services.AddTransient<IApplicationService<Dto.PedidoDetalle>, PedidoDetalleApplicationService>();
            services.AddTransient<IApplicationService<Dto.Pedido>, PedidoApplicationService>();
            services.AddTransient<IApplicationService<Dto.Producto>, ProductoApplicationService>();
            services.AddTransient<IApplicationService<Dto.Usuario>, UsuarioApplicationService>();
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();
        }
    }
}