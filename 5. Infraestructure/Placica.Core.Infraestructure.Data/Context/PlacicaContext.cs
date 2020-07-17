using System;
using System.Collections.Generic;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Parametro>().HasData(new List<Parametro>
            {
                new Parametro {
                    Id = 1, // PK
                    Descripcion = "Tipo Identificacion",
                    Titulo = "TIPOIDENTIFICACION",
                    Status = true,
                    UserCreate = "System",
                    UserModify = "System",
                    DateModify = DateTime.Now,
                    DateCreated = DateTime.Now,
                },
                new Parametro {
                    Id = 2, // PK
                    Descripcion = "Genero",
                    Titulo = "GENERO",
                    Status = true,
                    UserCreate = "System",
                    UserModify = "System",
                    DateModify = DateTime.Now,
                    DateCreated = DateTime.Now,
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
                    UserCreate = "System",
                    UserModify = "System",
                    DateModify = DateTime.Now,
                    DateCreated = DateTime.Now,
                },
                new ParametroDetalle {
                    Id = 2, // PK
                    Descripcion = "NIT",
                    Value = "NIT",
                    ParametroId = 1,
                    Status = true,
                    UserCreate = "System",
                    UserModify = "System",
                    DateModify = DateTime.Now,
                    DateCreated = DateTime.Now,
                },
                new ParametroDetalle {
                    Id = 3, // PK
                    Descripcion = "Masculino",
                    Value = "M",
                    ParametroId = 2,
                    Status = true,
                    UserCreate = "System",
                    UserModify = "System",
                    DateModify = DateTime.Now,
                    DateCreated = DateTime.Now,
                },
                new ParametroDetalle {
                    Id = 4, // PK
                    Descripcion = "Femenino",
                    Value = "F",
                    ParametroId = 2,
                    Status = true,
                    UserCreate = "System",
                    UserModify = "System",
                    DateModify = DateTime.Now,
                    DateCreated = DateTime.Now,
                },
            });
        }
    }
}