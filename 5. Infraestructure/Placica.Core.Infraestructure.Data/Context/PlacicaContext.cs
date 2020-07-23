using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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
        public DbSet<EmpresaCategoria> EmpresaCategorias { get; set; }
        public DbSet<Parametro> Parametro { get; set; }
        public DbSet<ParametroDetalle> ParametroDetalle { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // Get all the entities that inherit from AuditableEntity
            // and have a state of Added or Modified
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is EntityAudit && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            // For each entity we will set the Audit properties
            foreach (var entityEntry in entries)
            {
                // If the entity state is Added let's set
                // the CreatedAt and CreatedBy properties
                if (entityEntry.State == EntityState.Added)
                {
                    ((EntityAudit)entityEntry.Entity).CreatedDate = DateTimeOffset.Now;
                    ((EntityAudit)entityEntry.Entity).CreatedByUser = "MyApp";
                }
                else
                {
                    // If the state is Modified then we don't want
                    // to modify the CreatedAt and CreatedBy properties
                    // so we set their state as IsModified to false
                    Entry((EntityAudit)entityEntry.Entity).Property(p => p.CreatedDate).IsModified = false;
                    Entry((EntityAudit)entityEntry.Entity).Property(p => p.CreatedByUser).IsModified = false;
                }

                // In any case we always want to set the properties
                // ModifiedAt and ModifiedBy
                ((EntityAudit)entityEntry.Entity).ModifiedDate = DateTimeOffset.Now;
                ((EntityAudit)entityEntry.Entity).ModifiedByUser = "MyApp";
            }

            // After we set all the needed properties
            // we call the base implementation of SaveChangesAsync
            // to actually save our entities in the database
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Crear unique constraint
            modelBuilder.Entity<Usuario>()
            .HasIndex(u => u.UserId)
            .IsUnique();

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