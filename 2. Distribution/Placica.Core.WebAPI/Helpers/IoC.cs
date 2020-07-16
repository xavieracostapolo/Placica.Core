using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Placica.Core.WebAPI.Services.Contracts;
using Placica.Core.WebAPI.Services.Implementacion;
using Placica.Core.WebAPI.Models.Validation;
using Model = Placica.Core.WebAPI.Models;

namespace Placica.Core.WebAPI.Helpers
{
    public static class IoC
    {
        public static void AddDependencyDistribution(this IServiceCollection services)
        {
            services.AddTransient<IService<Model.Calificacion>, CalificacionService>();
            services.AddTransient<IService<Model.Categoria>, CategoriaService>();
            services.AddTransient<IService<Model.Cliente>, ClienteService>();
            services.AddTransient<IService<Model.Empresa>, EmpresaService>();
            services.AddTransient<IService<Model.PedidoDetalle>, PedidoDetalleService>();
            services.AddTransient<IService<Model.Pedido>, PedidoService>();
            services.AddTransient<IService<Model.Producto>, ProductoService>();

            services.AddTransient<IValidator<Model.Cliente>, ClienteValidator>();

            services.AddScoped<ModelValidationAttribute>();
        }
    }
}