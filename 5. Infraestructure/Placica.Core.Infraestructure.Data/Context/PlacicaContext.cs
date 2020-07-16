using Microsoft.EntityFrameworkCore;
using Placica.Core.Library.Entities;

namespace Placica.Core.Infraestructure.Data.Context
{
    public class PlacicaContext : DbContext
    {
        public PlacicaContext(DbContextOptions<PlacicaContext> options)
            : base(options)
        {
        }

        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}