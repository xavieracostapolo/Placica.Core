using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Audit.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Placica.Core.Library.Entities;

namespace Placica.Core.Infraestructure.Data.Context
{
    public class PlacicaContext : DbContext
    {
        private static DbContextHelper _helper = new DbContextHelper();
        private readonly IAuditDbContext _auditContext;

        public PlacicaContext(DbContextOptions<PlacicaContext> options)
            : base(options)
        {
            _auditContext = new DefaultAuditContext(this);
            _helper.SetConfig(_auditContext);
        }

        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EmpresaCategoria> EmpresaCategorias { get; set; }
        public DbSet<Parametro> Parametro { get; set; }
        public DbSet<ParametroDetalle> ParametroDetalle { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ProcessSave();
            return await _helper.SaveChangesAsync(_auditContext, () => base.SaveChangesAsync(cancellationToken));
        }

        private void ProcessSave()
        {
            var currentTime = DateTimeOffset.UtcNow;
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added && e.Entity is EntityAudit))
            {
                var entidad = item.Entity as EntityAudit;
                entidad.CreatedDate = currentTime;
                entidad.CreatedByUser = "";
                entidad.ModifiedDate = currentTime;
                entidad.ModifiedByUser = "";
            }

            foreach (var item in ChangeTracker.Entries()
                .Where(predicate: e => e.State == EntityState.Modified && e.Entity is EntityAudit))
            {
                var entidad = item.Entity as EntityAudit;
                entidad.ModifiedDate = currentTime;
                entidad.ModifiedByUser = "";
                item.Property(nameof(entidad.CreatedDate)).IsModified = false;
                item.Property(nameof(entidad.CreatedByUser)).IsModified = false;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Parametro>().HasData(new List<Parametro>
            {
                new Parametro {
                    Id = 1, // PK
                    Descripcion = "Tipo Identificacion",
                    Titulo = "TIPOIDENTIFICACION",
                    Status = true,
                    CreatedByUser = "System",
                    ModifiedByUser = "System",
                    CreatedDate = DateTimeOffset.UtcNow,
                    ModifiedDate = DateTimeOffset.UtcNow,
                },
                new Parametro {
                    Id = 2, // PK
                    Descripcion = "Genero",
                    Titulo = "GENERO",
                    Status = true,
                    CreatedByUser = "System",
                    ModifiedByUser = "System",
                    CreatedDate = DateTimeOffset.UtcNow,
                    ModifiedDate = DateTimeOffset.UtcNow,
                },
            });

            modelBuilder.Entity<ParametroDetalle>().HasData(new List<ParametroDetalle>
            {
                new ParametroDetalle {
                    Id = 1, // PK
                    Descripcion = "Cedula",
                    Value = "Cedula",
                    ParametroId = 1,
                    Status = true,
                    CreatedByUser = "System",
                    ModifiedByUser = "System",
                    CreatedDate = DateTimeOffset.UtcNow,
                    ModifiedDate = DateTimeOffset.UtcNow,
                },
                new ParametroDetalle {
                    Id = 2, // PK
                    Descripcion = "NIT",
                    Value = "NIT",
                    ParametroId = 1,
                    Status = true,
                    CreatedByUser = "System",
                    ModifiedByUser = "System",
                    CreatedDate = DateTimeOffset.UtcNow,
                    ModifiedDate = DateTimeOffset.UtcNow,
                },
                new ParametroDetalle {
                    Id = 3, // PK
                    Descripcion = "Masculino",
                    Value = "M",
                    ParametroId = 2,
                    Status = true,
                    CreatedByUser = "System",
                    ModifiedByUser = "System",
                    CreatedDate = DateTimeOffset.UtcNow,
                    ModifiedDate = DateTimeOffset.UtcNow,
                },
                new ParametroDetalle {
                    Id = 4, // PK
                    Descripcion = "Femenino",
                    Value = "F",
                    ParametroId = 2,
                    Status = true,
                    CreatedByUser = "System",
                    ModifiedByUser = "System",
                    CreatedDate = DateTimeOffset.UtcNow,
                    ModifiedDate = DateTimeOffset.UtcNow,
                },
            });
        }
    }
}