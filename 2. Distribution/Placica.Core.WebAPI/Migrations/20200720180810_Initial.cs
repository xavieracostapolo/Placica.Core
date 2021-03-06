﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Placica.Core.WebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParametroDetalles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    ParametroId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametroDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParametroDetalles_Parametros_ParametroId",
                        column: x => x.ParametroId,
                        principalTable: "Parametros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    TipoIdentificacionId = table.Column<long>(nullable: true),
                    Identificacion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_ParametroDetalles_TipoIdentificacionId",
                        column: x => x.TipoIdentificacionId,
                        principalTable: "ParametroDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    TipoIdentificacionId = table.Column<long>(nullable: true),
                    Identificacion = table.Column<string>(nullable: true),
                    RazonSocial = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Telefonos = table.Column<string>(nullable: true),
                    Responsables = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TipoId = table.Column<long>(nullable: true),
                    SitioWeb = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    Color1 = table.Column<string>(nullable: true),
                    Color2 = table.Column<string>(nullable: true),
                    Color3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_Parametros_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Parametros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresas_ParametroDetalles_TipoIdentificacionId",
                        column: x => x.TipoIdentificacionId,
                        principalTable: "ParametroDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaCategorias",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    EmpresaId = table.Column<long>(nullable: false),
                    CategoriaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaCategorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaCategorias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaCategorias_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    FechaDoc = table.Column<DateTime>(nullable: false),
                    EmpresaId = table.Column<long>(nullable: false),
                    ClienteId = table.Column<long>(nullable: false),
                    ValorTotal = table.Column<decimal>(nullable: false),
                    Impuesto = table.Column<decimal>(nullable: false),
                    Descuento = table.Column<decimal>(nullable: false),
                    Envio = table.Column<decimal>(nullable: false),
                    EmpTipoIdentificacion = table.Column<string>(nullable: true),
                    EmpIdentificacion = table.Column<string>(nullable: true),
                    EmpRazonSocial = table.Column<string>(nullable: true),
                    EmpDireccion = table.Column<string>(nullable: true),
                    EmpTelefonos = table.Column<string>(nullable: true),
                    EmpResponsables = table.Column<string>(nullable: true),
                    EmpEmail = table.Column<string>(nullable: true),
                    CliTipoIdentificacion = table.Column<string>(nullable: true),
                    CliIdentificacion = table.Column<string>(nullable: true),
                    CliEmail = table.Column<string>(nullable: true),
                    CliNombre = table.Column<string>(nullable: true),
                    CliApellido = table.Column<string>(nullable: true),
                    CliDireccion = table.Column<string>(nullable: true),
                    CliTelefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Imagen = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Presentacion = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    EmpresaId = table.Column<long>(nullable: false),
                    CategoriaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    ParametroDetalleId = table.Column<long>(nullable: false),
                    PedidoId = table.Column<long>(nullable: false),
                    ProductoId = table.Column<long>(nullable: true),
                    Valor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calificaciones_ParametroDetalles_ParametroDetalleId",
                        column: x => x.ParametroDetalleId,
                        principalTable: "ParametroDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calificaciones_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PedidoDetalles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    PedidoId = table.Column<long>(nullable: false),
                    ProductoId = table.Column<long>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    ValorUnitario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoDetalles_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoDetalles_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Parametros",
                columns: new[] { "Id", "CreatedByUser", "CreatedDate", "Descripcion", "ModifiedByUser", "ModifiedDate", "Status", "Titulo" },
                values: new object[] { 1L, "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 494, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, 0, 0, 0, 0)), "Tipo Identificacion", "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 494, DateTimeKind.Unspecified).AddTicks(7420), new TimeSpan(0, 0, 0, 0, 0)), true, "TIPOIDENTIFICACION" });

            migrationBuilder.InsertData(
                table: "Parametros",
                columns: new[] { "Id", "CreatedByUser", "CreatedDate", "Descripcion", "ModifiedByUser", "ModifiedDate", "Status", "Titulo" },
                values: new object[] { 2L, "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 494, DateTimeKind.Unspecified).AddTicks(8220), new TimeSpan(0, 0, 0, 0, 0)), "Genero", "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 494, DateTimeKind.Unspecified).AddTicks(8240), new TimeSpan(0, 0, 0, 0, 0)), true, "GENERO" });

            migrationBuilder.InsertData(
                table: "ParametroDetalles",
                columns: new[] { "Id", "CreatedByUser", "CreatedDate", "Descripcion", "ModifiedByUser", "ModifiedDate", "ParametroId", "Status", "Value" },
                values: new object[,]
                {
                    { 1L, "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7550), new TimeSpan(0, 0, 0, 0, 0)), "Cedula", "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 0, 0, 0, 0)), 1L, true, "Cedula" },
                    { 2L, "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), "NIT", "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), 1L, true, "NIT" },
                    { 3L, "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7740), new TimeSpan(0, 0, 0, 0, 0)), "Masculino", "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7740), new TimeSpan(0, 0, 0, 0, 0)), 2L, true, "M" },
                    { 4L, "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 0, 0, 0, 0)), "Femenino", "System", new DateTimeOffset(new DateTime(2020, 7, 20, 18, 8, 9, 496, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 0, 0, 0, 0)), 2L, true, "F" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_ParametroDetalleId",
                table: "Calificaciones",
                column: "ParametroDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_ProductoId",
                table: "Calificaciones",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoIdentificacionId",
                table: "Clientes",
                column: "TipoIdentificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaCategorias_CategoriaId",
                table: "EmpresaCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaCategorias_EmpresaId",
                table: "EmpresaCategorias",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TipoId",
                table: "Empresas",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TipoIdentificacionId",
                table: "Empresas",
                column: "TipoIdentificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametroDetalles_ParametroId",
                table: "ParametroDetalles",
                column: "ParametroId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDetalles_PedidoId",
                table: "PedidoDetalles",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDetalles_ProductoId",
                table: "PedidoDetalles",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EmpresaId",
                table: "Pedidos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_EmpresaId",
                table: "Productos",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropTable(
                name: "EmpresaCategorias");

            migrationBuilder.DropTable(
                name: "PedidoDetalles");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "ParametroDetalles");

            migrationBuilder.DropTable(
                name: "Parametros");
        }
    }
}
