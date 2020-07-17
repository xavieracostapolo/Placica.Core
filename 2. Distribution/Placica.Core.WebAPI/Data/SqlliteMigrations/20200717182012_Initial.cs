using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Placica.Core.WebAPI.Data.SqlliteMigrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Data");

            migrationBuilder.CreateTable(
                name: "Categorias",
                schema: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCreate = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserModify = table.Column<string>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                schema: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCreate = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserModify = table.Column<string>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false),
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
                schema: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCreate = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserModify = table.Column<string>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    ParametroId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametroDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParametroDetalles_Parametros_ParametroId",
                        column: x => x.ParametroId,
                        principalSchema: "Data",
                        principalTable: "Parametros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                schema: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCreate = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserModify = table.Column<string>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false),
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
                        principalSchema: "Data",
                        principalTable: "ParametroDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                schema: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCreate = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserModify = table.Column<string>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false),
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
                        principalSchema: "Data",
                        principalTable: "Parametros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresas_ParametroDetalles_TipoIdentificacionId",
                        column: x => x.TipoIdentificacionId,
                        principalSchema: "Data",
                        principalTable: "ParametroDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaCategorias",
                schema: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCreate = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserModify = table.Column<string>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false),
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
                        principalSchema: "Data",
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaCategorias_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalSchema: "Data",
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                schema: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCreate = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserModify = table.Column<string>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false),
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
                        principalSchema: "Data",
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalSchema: "Data",
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                schema: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCreate = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserModify = table.Column<string>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false),
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
                        principalSchema: "Data",
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalSchema: "Data",
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                schema: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCreate = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserModify = table.Column<string>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false),
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
                        principalSchema: "Data",
                        principalTable: "ParametroDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calificaciones_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalSchema: "Data",
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PedidoDetalles",
                schema: "Data",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserCreate = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserModify = table.Column<string>(nullable: false),
                    DateModify = table.Column<DateTime>(nullable: false),
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
                        principalSchema: "Data",
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoDetalles_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalSchema: "Data",
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_ParametroDetalleId",
                schema: "Data",
                table: "Calificaciones",
                column: "ParametroDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_ProductoId",
                schema: "Data",
                table: "Calificaciones",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoIdentificacionId",
                schema: "Data",
                table: "Clientes",
                column: "TipoIdentificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaCategorias_CategoriaId",
                schema: "Data",
                table: "EmpresaCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaCategorias_EmpresaId",
                schema: "Data",
                table: "EmpresaCategorias",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TipoId",
                schema: "Data",
                table: "Empresas",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TipoIdentificacionId",
                schema: "Data",
                table: "Empresas",
                column: "TipoIdentificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametroDetalles_ParametroId",
                schema: "Data",
                table: "ParametroDetalles",
                column: "ParametroId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDetalles_PedidoId",
                schema: "Data",
                table: "PedidoDetalles",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDetalles_ProductoId",
                schema: "Data",
                table: "PedidoDetalles",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                schema: "Data",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EmpresaId",
                schema: "Data",
                table: "Pedidos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaId",
                schema: "Data",
                table: "Productos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_EmpresaId",
                schema: "Data",
                table: "Productos",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificaciones",
                schema: "Data");

            migrationBuilder.DropTable(
                name: "EmpresaCategorias",
                schema: "Data");

            migrationBuilder.DropTable(
                name: "PedidoDetalles",
                schema: "Data");

            migrationBuilder.DropTable(
                name: "Pedidos",
                schema: "Data");

            migrationBuilder.DropTable(
                name: "Productos",
                schema: "Data");

            migrationBuilder.DropTable(
                name: "Clientes",
                schema: "Data");

            migrationBuilder.DropTable(
                name: "Categorias",
                schema: "Data");

            migrationBuilder.DropTable(
                name: "Empresas",
                schema: "Data");

            migrationBuilder.DropTable(
                name: "ParametroDetalles",
                schema: "Data");

            migrationBuilder.DropTable(
                name: "Parametros",
                schema: "Data");
        }
    }
}
